# Projeto Base de Conhecimento
Este projeto visa o aprendizado do leitor, portanto não é aconcelhável a utilização do mesmo em produção, 
já que os protocolo de segurança e tratamento de excessão foram 
negligenciados quando os mesmos não cuprem o papel didático.

# Visão Geral
## Ferramentas
| Ferramenta | Descrição |
|:-- |:-- |
| Visual Studio | IDE para desenvolvimento do Aplicativo |
| MySQL Workbench | IDE para operações no banco de dados |
| MySQL Server | Serviço de banco de dados Mysql para base de dados |

## Pré-requisito
| Conteúdo |
|:------- |
| Entendimento de Projeto WEB API Visual Studio |
| Entendimento de Mysql básico |
| Acesso a um serviço MySql |

## Assuntos abordados
- Arquitetura de software **DDD**
- Injeção de dependência
- Web API .NET Core 3.1

# O Projeto
## Definição
Uma base de conhecimento é um conjunto de perguntas e respostas agrupadas por categorias com o 
objetivo de ofertar soluções para dúvidas do usuário. Você pode se deparar nos sites com um item
chamado "FAQ" ou "Perguntas Frequentes" ou "knowledge" ou "troubleshoot", basicamente todos
tem a mesma função, possuem um conjunto de respostas para perguntas ou dúvidas.

### Requisitos Funcionais
- Um sistema de cadastro de Base de conhecimento
- As bases de conhecimento deverão ser agrupada por categoria

### Requisitos **NÃO** funcionais
- Deve ser Web
- Os dados deverão estar disponível via API
- Deve ser compatível com .NET Core
- Banco de dados MySql

## Preparando o Projeto
> Crie um schema no banco de dados MYSQL e execute o script de criação da estrutura

A estrutura é simples:
- Tabela de categorias
- Tabela de conhecimento (base de conhecimento)

**ANEXO 1**

```sql
---------------------------------------------------
---- SQL Create Database
---------------------------------------------------

-- Criando tabela de categoria
create table categoria (
    id                  int not null auto_increment primary key,
    criado_em           datetime not null default now(),
    modificado_em       datetime not null default now(),
    nome                varchar(30) not null,
    apelido             varchar(30) not null unique,
    descricao           varchar(250) null
);

-- Criando tabela de base de conhecimento
create table base_conhecimento(
    id                      char(36) not null primary key,
    criado_em               datetime not null default now(),
    modificado_em           datetime not null default now(),
    categoria_id            int null,
    titulo                  varchar(150) not null,
    apelido                 varchar(150) not null unique,
    descricao               varchar(900) null,
    ativo                   bit not null default 1,
    
    constraint fk_baseconhecimento_categoria foreign key (categoria_id) references categoria(id)
);

-- Criação de View de Categoria visando vincular o Model
create view vm_categoria as
select 
    id                  Id,
    criado_em           CriadoEm,
    modificado_em       ModificadoEm,
    nome                Nome,
    apelido             Apelido,
    descricao           Descricao

from categoria;

-- Criação de View de Categoria visando vincular o Model
create view vm_base_conhecimento as
select 
    id                  Id,
    criado_em           CriadoEm,
    modificado_em       ModificadoEm,
    categoria_id        CategoriaId,
    titulo              Titulo,
    apelido             Apelido,
    descricao           Descricao,
    ativo               Ativo

from base_conhecimento;
```

# Teorias Aplicadas
## Arquitetura do projeto
> Decidi utilizar o modelo DDD, (é possível entender muito desse padrão de projetos na internet).

|| Categoria | Base de Conhecimento | API  |
|:--|:--|:--|--|
|App| DDD

> Aqui eu vou focar na prática, em outro momento falaremos do assunto.