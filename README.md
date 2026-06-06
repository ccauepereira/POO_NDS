# Sistema de Autenticação e Caixa Eletrônico em POO 🚀

Este repositório contém dois projetos desenvolvidos em **C#** utilizando o ecossistema **.NET 10**, focados na aplicação prática de **Programação Orientada a Objetos (POO)**, encapsulamento, tratamento de dados por meio de Tuplas e lógica de fluxo com estruturas de repetição.

---

## 📁 Estrutura do Repositório

O repositório é organizado em uma única solução (`.sln`) que gerencia dois projetos principais localizados na raiz:

* **`PaginaLogin/`**: Sistema base de autenticação, focado na validação de credenciais, tratamento de estados (sucesso/falha) e armazenamento em memória.
* **`SysCaixaEletronico/`**: Sistema bancário interativo que expande o conceito de login para gerenciar contas bancárias associadas aos usuários, permitindo operações financeiras com validações defensivas.

---

## 🛠️ Tecnologias Utilizadas

* **Linguagem:** C#
* **Ambiente de Execução:** .NET 10
* **IDE:** JetBrains Rider
* **Controle de Versão:** Git / GitHub

---

## ⚙️ Funcionalidades dos Projetos

### 1. Página de Login (`PaginaLogin`)
* **Cadastro Avançado:** Validação defensiva (nomes não nulos/vazios, senhas com no mínimo 4 caracteres e bloqueio de usuários duplicados).
* **Autenticação Eficiente:** Busca em listas utilizando expressões Lambda com `FirstOrDefault`.
* **Menu de Controle Dinâmico:** Interface via console que se adapta se houver ou não usuários cadastrados.

### 2. Caixa Eletrônico (`SysCaixaEletronico`)
* **Entidades Isoladas:** Separação estrita de responsabilidades entre as classes `Usuario`, `ContaBancaria` e `SistemaLogin`.
* **Validação de Negócio:** Depósitos e saques controlados por operadores relacionais e lógicos, impedindo valores negativos ou saques superiores ao saldo atual.
* **Formatação de Moeda:** Utilização de interpolação com especificadores de formato de cultura (`:C`) para exibição monetária automatizada.

---

## 🚀 Como Rodar os Projetos

Como os projetos utilizam a estrutura padrão do .NET CLI, podes rodá-los diretamente pelo teu terminal.

### Pré-requisitos
Certifica-te de que tens o SDK do .NET instalado na tua máquina.

### Executando a Página de Login
```bash
cd PaginaLogin
dotnet run

```
### Executando o Caixa Eletrônico
```bash
cd SysCaixaEletronico
dotnet run

```
## 🧑‍💻 Autor
Desenvolvido por **vvankxs** como parte do aprendizado prático de arquitetura de software, POO e manipulação do ecossistema .NET.
```

```
