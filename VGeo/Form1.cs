using System.Net.Http;
using System.Windows.Forms;
using static VGeo.Model.VGeo;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Text;
using OfficeOpenXml;
using VGeo.Model;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace VGeo
{
    public partial class Form1 : Form
    {
        HttpClient client = new HttpClient();
        private string UF;
        private bool isHandlingItemCheck = false;
        private List<string> valoresSelecionados = new List<string>();
        private string filePath;
        public Form1()
        {
            InitializeComponent();
            PopularComboBoxEstados();
            for (int i = 0; i < lbUF.Items.Count; i++)
            {
                if (lbUF.Items[i].ToString() == "PR")
                {
                    lbUF.SetSelected(i, true);  // Seleciona o item
                    GetBR(lbUF.Items[i].ToString());
                    break;  // Encerra o loop ao encontrar "PR"
                }
            }
            tbDiretorio.Text = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        }

        private void brnPOrocesss_Click(object sender, EventArgs e)
        {
            tbLog.Text = "";
            // PercorrerUF();
            // Verifica se existe algum item marcado no CheckedListBox
            if (lbUF.SelectedItem.ToString().Length == 0) // Nenhum item marcado
            {
                MessageBox.Show("Selecione pelo menos um estado.");
            }
            else
            {

                ExecuteAsync(lbUF.SelectedItem.ToString()); // Passa o valor para ExecuteAsync
                btFile.Visible = true;
            }


        }

        private async void ExecuteAsync(string uf)
        {
            try
            {
                // Exibir a barra de progresso
                progressBar.Visible = true;
                progressBar.Style = ProgressBarStyle.Marquee; // Estilo contínuo

                // Definindo o contexto da licença como uso não comercial
                ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
                // Caminho onde o arquivo Excel será salvo
                //filePath = tbDiretorio.Text + "DadosRotas.xlsx";
                filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), $"DadosRotas{lbUF.SelectedItem.ToString()}.xlsx");

                // Cria uma nova planilha Excel
                using (var package = new ExcelPackage())
                {
                    // Adiciona uma aba à planilha
                    var worksheet = package.Workbook.Worksheets.Add("Dados Rotas");

                    // Adicionar cabeçalhos na planilha
                    worksheet.Cells[1, 1].Value = "UF";
                    worksheet.Cells[1, 2].Value = "BR";
                    worksheet.Cells[1, 3].Value = "KM";
                    worksheet.Cells[1, 4].Value = "Data";
                    worksheet.Cells[1, 5].Value = "Coordenadas";

                    int row = 2;

                    // Percorrer cada BR na ListBox lbBR
                    foreach (var item in lbBR.Items)
                    {
                        string br = item.ToString(); // Obter o valor do BR

                        // Percorrer os km de 490 a 500
                        for (int km = Int32.Parse(tbKmBegin.Text); km <= Int32.Parse(tbKmEnd.Text); km++)
                        {
                            // Faz a requisição GET para a API
                            var response = await client.GetAsync($"https://servicos.dnit.gov.br/sgplan/apigeo/rotas/espacializarponto?br={br}&tipo=B&uf={uf}&cd_tipo=null&data=2024-10-16&km={km}");

                            // Verifica se a resposta foi bem-sucedida
                            if (!response.IsSuccessStatusCode)
                            {
                                Console.WriteLine($"Nenhum dado encontrado para o km {km}. Encerrando a execução para BR {br}.");
                                break; // Encerra o loop caso não encontre dados para este BR
                            }

                            // Lê o conteúdo da resposta
                            var responseContent = await response.Content.ReadAsStringAsync();

                            // Desserializa o JSON para o objeto Feature
                            var feature = JsonConvert.DeserializeObject<Feature>(responseContent);

                            if (feature == null || feature.Properties == null || feature.Geometry == null)
                            {
                                Console.WriteLine($"Nenhum dado encontrado para o km {km}. Encerrando a execução para BR {br}.");
                                break; // Encerra o loop se não houver dados válidos
                            }

                            // Extrair os dados e adicionar uma linha à planilha
                            var coordenadas = $"{feature.Geometry.Coordinates[0][0]}, {feature.Geometry.Coordinates[0][1]}";
                            worksheet.Cells[row, 1].Value = feature.Properties.Uf;
                            worksheet.Cells[row, 2].Value = feature.Properties.Br;
                            worksheet.Cells[row, 3].Value = feature.Properties.Km;
                            worksheet.Cells[row, 4].Value = feature.Properties.Data;
                            worksheet.Cells[row, 5].Value = coordenadas;

                            // Atualizar o log (opcional)
                            tbLog.Text += $"BR: {feature.Properties.Br}, UF: {feature.Properties.Uf}, KM: {feature.Properties.Km}, Data: {feature.Properties.Data}, Coordenadas: {coordenadas}\n";

                            // Incrementa a linha para a próxima inserção
                            row++;
                        }
                    }
                    try
                    {
                        // Salva o arquivo Excel
                        File.WriteAllBytes(filePath, package.GetAsByteArray());
                        tbStatus.Text = ("Dados salvos com sucesso em: " + filePath + $"DadosRotas{lbUF.SelectedItem.ToString()}.xlsx");
                        //MessageBox.Show("Dados salvos com sucesso em: " + filePath);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                }
            }
            catch (HttpRequestException e)
            {
                // Tratar o erro
                Console.WriteLine("Erro ao fazer a requisição: " + e.Message);
            }
            catch (Exception ex)
            {
                // Tratar quaisquer outros erros
                Console.WriteLine("Erro inesperado: " + ex.Message);
            }
            finally
            {
                // Ocultar a barra de progresso
                progressBar.Visible = false;
            }
        }

        private async void GetBR(string uf)
        {
            try
            {
                // Verifica se o parâmetro `uf` foi fornecido
                if (string.IsNullOrEmpty(uf))
                {
                    Console.WriteLine("UF não fornecida.");
                    return;
                }

                // Faz a requisição GET para a API
                var response = await client.GetAsync($"https://servicos.dnit.gov.br/sgplan/apigeo/snv/listarbrporuf?data=2024-10-16T17:49:26.399Z&uf={uf}");

                // Verifica se a resposta foi bem-sucedida
                if (!response.IsSuccessStatusCode)
                {
                    Console.WriteLine($"Erro: a resposta da API retornou o status {response.StatusCode}");
                    return;
                }

                // Lê o conteúdo da resposta
                var responseContent = await response.Content.ReadAsStringAsync();

                // Desserializa o JSON para o objeto BrModel
                var brModel = JsonConvert.DeserializeObject<BrModel>(responseContent);

                // Verifica se a desserialização retornou um objeto válido
                if (brModel == null || string.IsNullOrEmpty(brModel.lista_br))
                {
                    Console.WriteLine("Erro: Não foi possível desserializar o JSON ou lista de BRs vazia.");
                    return;
                }

                // Limpa o ListBox antes de popular
                lbBR.Items.Clear();

                // Popula o ListBox com a lista de BRs
                var listaBr = brModel.lista_br.Split(','); // Divide a string de BRs separadas por vírgula

                foreach (var br in listaBr)
                {
                    lbBR.Items.Add(br.Trim()); // Adiciona cada BR à lista, removendo espaços em branco
                }

                // Atualiza o log (opcional)
                Console.WriteLine($"UF: {brModel.Uf}, Lista de BRs: {brModel.lista_br}");
            }
            catch (HttpRequestException e)
            {
                // Tratar o erro de requisição HTTP
                Console.WriteLine("Erro ao fazer a requisição: " + e.Message);
            }
            catch (Exception ex)
            {
                // Tratar quaisquer outros erros
                Console.WriteLine("Erro inesperado: " + ex.Message);
            }
        }

        private void PopularComboBoxEstados()
        {
            // Lista de siglas dos estados brasileiros
            List<string> estados = new List<string>
        {
            "TODOS", "AC", "AL", "AP", "AM", "BA", "CE", "DF", "ES", "GO", "MA",
            "MT", "MS", "MG", "PA", "PB", "PR", "PE", "PI", "RJ", "RN",
            "RS", "RO", "RR", "SC", "SP", "SE", "TO"
        };

            // Adiciona as siglas no ComboBox
            lbUF.DataSource = estados;

        }

        private void clbUF_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lbUF_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetBR(lbUF.SelectedItem.ToString());
        }

        private void btFile_Click(object sender, EventArgs e)
        {
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            System.Diagnostics.Process.Start("explorer.exe", desktopPath);
            //try
            //{
            //    using (var fbd = new FolderBrowserDialog())
            //    {
            //        fbd.Description = "Selecione uma pasta";
            //        fbd.InitialDirectory = @"C:\"; // ou qualquer diretório inicial que você preferir

            //        DialogResult result = fbd.ShowDialog();

            //        if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
            //        {
            //            // Define o caminho da pasta selecionada no TextBox
            //            tbDiretorio.Text = fbd.SelectedPath;
            //            filePath = fbd.SelectedPath;
            //        }
            //    }
            //}
            //catch (Exception err)
            //{
            //    MessageBox.Show("Erro ao carregar a pasta: " + err.Message);
            //}
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
