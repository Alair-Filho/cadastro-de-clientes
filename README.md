# 🧾 Sistema de Cadastro de Clientes - Windows Forms

Este projeto é uma aplicação de **Cadastro de Clientes** desenvolvida em **C# com Windows Forms** e banco de dados **MySQL Workbench**. O sistema permite gerenciar os dados dos clientes com funcionalidades completas de CRUD, pesquisa, filtros, geração de relatórios e integração com API de CEP.

🎥 Demonstração:
[![Assistir Demonstração no YouTube](https://img.youtube.com/vi/jhnaX2X6Ay0/hqdefault.jpg)](https://youtu.be/jhnaX2X6Ay0)

---

## 📌 Funcionalidades

- ✅ Cadastro de clientes com os seguintes campos:
  - ID
  - Nome
  - CPF ou CNPJ
  - Gênero
  - RG
  - Estado Civil
  - Data de Nascimento
  - CEP (com consulta via API)
  - Endereço
  - Número da Casa
  - Bairro
  - Estado
  - Cidade
  - Celular
  - Email
  - Observação
  - Situação (Ativo ou Cancelado)
  - Foto do Cliente (com opção de adicionar/remover imagem; imagem padrão exibida quando vazio)

- 🛑 Validação de campos obrigatórios no formulário de cadastro.

- 🔍 **Barra de pesquisa** com filtros:
  - ID
  - Nome
  - Documento
  - Gênero
  - Estado Civil
  - Endereço
  - Data de Nascimento
  - Situação: Ativo / Cancelado / Todos

- 📋 **Lista de clientes** com todos os dados visíveis.
  - Clientes com situação "Cancelado" são exibidos com texto em **vermelho**.

---

## 🧭 Menu Principal

Na tela de listagem de clientes, há 4 botões principais localizados no canto superior esquerdo:

1. **➕ Novo Cliente**  
   Abre a aba de cadastro de cliente para adicionar um novo registro.

2. **✏️ Atualizar Cliente**  
   - Inicialmente desativado.
   - Ativado ao selecionar um cliente.
   - Ao clicar, carrega os dados do cliente selecionado para edição.
   - Permite salvar alterações no banco de dados.

3. **📄 Gerar Relatório (PDF)**  
   Gera um relatório em PDF com todos os clientes cadastrados.

4. **🖨️ Imprimir Ficha Cadastral**  
   - Desativado enquanto nenhum cliente estiver selecionado.
   - Imprime os dados completos do cliente selecionado.

---

## 💾 Banco de Dados

O sistema está integrado a um banco de dados **MySQL Workbench**, onde todas as informações são armazenadas de forma segura e estruturada.

---

## 🌐 API de CEP

Utiliza uma API de consulta de CEP para preencher automaticamente:
- Endereço
- Bairro
- Cidade
- Estado

---

## 🖼️ Fotos de Perfil

- É possível **adicionar uma foto** ao perfil do cliente.
- Também é possível **remover a foto**.
- Caso nenhum arquivo de imagem seja adicionado, uma **imagem padrão sem rosto** é exibida.

---

## 🚀 Como Executar

1. Compile o projeto no Visual Studio (**Ctrl + Shift + B**).
2. Navegue até a pasta `bin/Debug` ou `bin/Release` dentro do diretório do projeto.
3. Execute o arquivo `.exe` gerado para iniciar a aplicação sem precisar abrir o Visual Studio.
4. Certifique-se de que o **MySQL** está rodando e que o banco de dados está corretamente configurado.
5. É necessário também estar com **acesso à internet** para que a consulta à **API ViaCEP** funcione corretamente.

> 💡 Caso queira abrir e editar o projeto, basta abrir o arquivo `.sln` no Visual Studio.

---

## 🛠 Requisitos

- .NET Framework (ou .NET 6/7, dependendo do alvo de compilação)
- MySQL Server e MySQL Workbench instalados
- API de CEP acessível pela internet
- Permissões de leitura/gravação na pasta onde o `.exe` for executado

---

## ⚠️ Avisos

- Todos os dados utilizados no sistema são **fictícios**, criados apenas para fins de demonstração e testes.
- Os **ícones** foram retirados do site [Icons8](https://icons8.com/), com os devidos créditos mantidos.

---

## 👨‍💻 Autor

**Alair de Paula Filho**  
[LinkedIn](https://www.linkedin.com/in/alair-de-paula-filho-832ba9301)  
[GitHub](https://github.com/Alair-Filho)

