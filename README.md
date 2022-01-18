# Projeto Base de Conhecimento
Este projeto visa o aprendizado do leitor, portanto não é aconcelhável a utilização do mesmo em produção, 
já que os protocolo de segurança e tratamento de excessão foram 
negligenciados quando os mesmos não cuprem o papel didático.

# Objetivos
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
| Entendimento de instalação de serviço Mysql (localhost) |

## Assuntos

# O Projeto
## Definição
Uma base de conhecimento é um conjunto de informações que vão sendo captadas para resolver 
problemas semelhantes no futuro. É como se fosse um conjunto de dúvidas **resolvidas**
agrupadas por categorias.

A estrutura é simples:
- Tabela de categorias
- Tabela de conhecimento (base de conhecimento)

Já que não iremos esquentar a cabeça com a complexidade das telas, vamos tentar ajustar nosso
__backend__ para que você obtenha mais conhecimento.

### Requisitos Funcionais
- Um sistema de cadastro de Base de conhecimento
- As bases de conhecimento deverão ser agrupada por categoria

### Requisitos **NÃO** funcionais
- Deve ser Web
- Os dados deverão estar disponível via API
- Deve ser compatível com .NET Core
- Banco de dados MySql

## Preparando o Projeto
> Crie um schema no banco de dados MYSQL e crie a estrutura de dados

A estrutura abaixo deverá cumprir os requisitos apontados.
```sql
---------------------------------------------------
---- SQL Create Database
---------------------------------------------------

-- Criando tabela de categoria
create table categoria (
    id					int not null auto_increment primary key,
    criado_em			datetime not null default now(),
    modificado_em		datetime not null default now(),
    nome				varchar(30) not null,
    apelido				varchar(30) not null unique,
    descricao			varchar(250) null,
    
    constraint fk_categoria_categoria_pai foreign key (categoria_pai_id) references categoria(id)
);

-- Criando tabela de base de conhecimento
create table base_conhecimento(
    id                      char(36) not null primary key,
    criado_em               datetime not null default now(),
    modificado_em           datetime not null default now(),
    categoria_id            int null,
    titulo                  varchar(150) not null,
    apelido                 varchar(150) not null unique,
    descricao_rapida        varchar(250) null,
    descricao               text not null,
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
    descricao           Descricao,

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
    descricao_rapida    DescricaoRapida,
    descricao           Descricao,
    ativo               Ativo

from base_conhecimento;
```

## Regras de negócio
### Definições
Este tipo de aplicação possui 2 lados:
- Lado de quem cadastra (admin)
- Lado de quem usa (livre)

Se é assim, os domínios também devem ser separados, pois cumprem funções diferentes no código.
