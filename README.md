# 🚚 Sistema de Logística para Transportadora

Projeto desenvolvido em **C# com .NET** para simular o gerenciamento de colaboradores de uma transportadora.

O sistema utiliza conceitos de **Programação Orientada a Objetos (POO)** para representar diferentes tipos de funcionários de transporte.

## 📌 Funcionalidades

- Cadastro de motoristas de carreta
- Cadastro de entregadores de moto
- Armazenamento de informações dos colaboradores
- Exibição dos detalhes de cada funcionário
- Listagem polimórfica dos colaboradores cadastrados

## 🧠 Conceitos de POO utilizados

O projeto aplica os seguintes conceitos:

- **Abstração:** utilização da classe abstrata `FuncionarioTransporte`
- **Herança:** `MotoristaCarreta` e `EntregadorMoto` herdam de `FuncionarioTransporte`
- **Encapsulamento:** propriedades protegidas por meio de `get` e `private set`
- **Construtores:** inicialização dos dados dos objetos e utilização de `base`
- **Polimorfismo:** sobrescrita do método `MostrarDetalhes()` utilizando `virtual` e `override`

## 📁 Estrutura do projeto

```text
SistemaLogistica/
│
├── Models/
│   ├── FuncionarioTransporte.cs
│   ├── MotoristaCarreta.cs
│   └── EntregadorMoto.cs
│
├── integrantes.txt
├── Program.cs
└── README.md
```

## 🛠️ Tecnologias utilizadas

- C#
- .NET
- Visual Studio
- Git
- GitHub

## ▶️ Execução

Ao executar o programa, são criados diferentes tipos de colaboradores e suas informações são exibidas no console por meio do método `MostrarDetalhes()`.

Exemplo:

```text
=== SISTEMA DE LOGÍSTICA ===

Nome: Carlos
Registro: FUNC001
Placa da carreta: ABC1D23
Categoria da CNH: E
---------------------------
Nome: Lucas
Registro: FUNC002
Placa da moto: XYZ9A87
Região de entrega: Zona Sul
---------------------------
```

## 👥 Integrantes

| Nome | RM |
|------|----|
| Musashi Mabuti | RM559444 |

## 🎓 Informações acadêmicas

**Curso:** Engenharia de Software  
**Disciplina:** C# Development  
**Turma:** 3ESPS  
**Professor:** Wellington Cidade Silva  
**Instituição:** FIAP
