-- create schema revista_basecon;
use revista_basecon;
create table categoria(
	id					int not null auto_increment primary key,
    criado_em			datetime not null default now(),
    modificado_em		datetime not null default now(),
    nome				varchar(30) not null,
    apelido				varchar(30) not null unique,
    descricao			varchar(250) null,
    categoria_pai_id	int null,
    
    constraint fk_categoria_categoria_pai foreign key (categoria_pai_id) references categoria(id)
);

create table base_conhecimento(
	id					char(36) not null primary key,
    criado_em			datetime not null default now(),
    modificado_em		datetime not null default now(),
    categoria_id		int null,
    titulo				varchar(150) not null,
    apelido				varchar(150) not null unique,
    descricao_rapida	varchar(250) null,
    descricao			text not null,
    ativo				bit not null,
    
    constraint fk_baseconhecimento_categoria foreign key (categoria_id) references categoria(id)
);
