# 🔐 UserAuth API (.NET 6)

[![.NET 6](https://img.shields.io/badge/.NET-6.0-512bd4?style=flat-square&logo=dotnet)](https://dotnet.microsoft.com/download/dotnet/6.0)
[![MySQL](https://img.shields.io/badge/MySQL-00758f?style=flat-square&logo=mysql&logoColor=white)](https://www.mysql.com/)
[![Argon2](https://img.shields.io/badge/Security-Argon2-blue?style=flat-square)](https://cheatsheetseries.owasp.org/cheatsheets/Password_Storage_Cheat_Sheet.html)

Uma API completa de autenticação e gerenciamento de identidade, projetada para ser o núcleo de segurança de aplicações modernas. O sistema implementa fluxos críticos como verificação de conta e recuperação de senha via e-mail.

## 🚀 Funcionalidades Principais

- **Registro de Usuário:** Com validação de duplicidade de e-mail e CPF.
- **Confirmação de Conta:** Envio de e-mail com token de verificação (o login só é permitido após a ativação).
- **Recuperação de Senha:** Fluxo seguro via e-mail com tokens de expiração temporária.
- **Segurança Avançada:** Armazenamento de senhas utilizando o algoritmo **Argon2**, seguindo as recomendações da OWASP.
- **Gestão de Perfil:** Atualização de dados e futura implementação de upload de fotos.

## 🏗️ Arquitetura e Tecnologias

O projeto utiliza uma estrutura desacoplada para facilitar a manutenção e escalabilidade:

- **Back-end:** ASP.NET Core Web API (.NET 6)
- **ORM:** Entity Framework Core 6
- **Banco de Dados:** MySQL
- **Mapeamento:** AutoMapper para conversão de DTOs.
- **Validação:** FluentValidation para regras de domínio e entrada.
- **Identidade:** Hashing Argon2 para proteção máxima de credenciais.

## ⚙️ Configuração

1. Clone o repositório.
2. No `appsettings.json`, configure sua Connection String do MySQL e suas credenciais de **SMTP** (para envio de e-mails).
3. Execute as Migrations:
   ```bash
   dotnet ef database update
4. Rode a aplicação e acesse o Swagger para testar os endpoints.

🚧 Status do Projeto
O projeto está em evolução.

[x] Fluxo de Autenticação Base.
[x] Recuperação de Senha via E-mail.
[ ] Implementação de Upload de Foto de Perfil.

👨‍💻 Desenvolvedor
Victor Vale - [LinkedIn](https://www.google.com/search?q=https://www.linkedin.com/in/jo%C3%A3o-victor-vale)
