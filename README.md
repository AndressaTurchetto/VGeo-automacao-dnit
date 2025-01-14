## VGeo - Service GetVGeo

VGeo é uma aplicação Windows Forms desenvolvida em C# que interage com a API VGeo para percorrer dados de estradas e gerar um arquivo de exportação em formato Excel (.xlsx). A ferramenta permite o usuário selecionar informações sobre trechos de rodovias, visualizar logs do processo e exportar os dados conforme necessário.

## Funcionalidades

Seleção de UF e BR: O usuário pode selecionar a UF (Unidade Federativa) e a BR (Rodovia Federal) a partir de listas dinâmicas.
Entrada de Quilometragem: O usuário pode definir os pontos de quilometragem inicial e final do trecho a ser processado.
Processamento de Dados: Ao clicar no botão "Processar", os dados são enviados para a API VGeo, processados e exportados em um arquivo Excel.
Exibição de Log: A aplicação exibe um log de eventos e status do processo em tempo real.
Barra de Progresso: A barra de progresso indica o andamento do processamento dos dados.
Interface Intuitiva: Layout simples e funcional para facilitar o uso, com separação clara de seções.

## Pré-Requisitos
Antes de rodar o projeto, assegure-se de ter os seguintes itens instalados:

.NET 6.
Visual Studio ou outro editor de C# com suporte a WinForms.

## Como Executar o Projeto
1. Clonar o Repositório
Clone o repositório para sua máquina local utilizando Git:

git clone https://github.com/AndressaTurchetto/VGeo-automacao-dnit.git

2. Abrir no Visual Studio
Abra o arquivo .sln no Visual Studio ou em outro IDE compatível com projetos .NET.

3. Restaurar Dependências
Se estiver utilizando bibliotecas externas, abra o NuGet Package Manager e restaure as dependências do projeto.

No Visual Studio:
Clique com o botão direito no projeto na Solution Explorer.
Selecione Restore NuGet Packages.

4. Executar o Projeto
Após restaurar as dependências, basta clicar em Start ou Run no Visual Studio para compilar e rodar o projeto.
