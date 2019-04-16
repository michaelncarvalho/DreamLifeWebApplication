# --- !Ups
CREATE SCHEMA dbo;

CREATE TABLE dbo.cidade(
	id SERIAL NOT NULL,
	nome CHARACTER VARYING(255),
	pais CHARACTER VARYING(255),
	estado VARCHAR(2),
	CONSTRAINT pk_cidadades PRIMARY KEY(id)
);

CREATE TABLE dbo.hotel(
	id SERIAL NOT NULL, 
	nome CHARACTER VARYING(255),
	id_cidade INTEGER NOT NULL,
	preco DOUBLE PRECISION,
    classificacao INTEGER,
    descricao TEXT,	
	CONSTRAINT pk_hotels PRIMARY KEY(id),
	CONSTRAINT fk_h_cidades FOREIGN KEY (id_cidade) REFERENCES dbo.cidade(id)
);

CREATE TABLE dbo.viagem(
	id SERIAL NOT NULL,
	id_hotel INTEGER NOT NULL,
	data_viagem DATE,
	quantidade_pessoas INTEGER,
	modalidade_viagem VARCHAR(100),
	CONSTRAINT pk_viagens PRIMARY KEY(id),
	CONSTRAINT fk_v_hoteis FOREIGN KEY(id_hotel) REFERENCES dbo.hotel(id) 
);

COMMENT ON TABLE dbo.cidade IS 'Entidade responsável por armazenar as informações das cidades';
COMMENT ON COLUMN dbo.cidade.id IS 'Identificador único da entidade';
COMMENT ON COLUMN dbo.cidade.nome IS 'Nome da cidade';
COMMENT ON COLUMN dbo.cidade.esrado IS 'Estado da cidade Ex: MG, SP, ...';

COMMENT ON TABLE dbo.hotel IS 'Entidade responsável por armazenar as informações de hoteis cadastrados';
COMMENT ON COLUMN dbo.hotel.id IS 'Identificador único da entidade';
COMMENT ON COLUMN dbo.hotel.nome IS 'Nome do hotel';
COMMENT ON COLUMN dbo.hotel.id_cidade IS 'Identificador da Entidade Cidade que realiza o relacionamento com a Entidade Hotel';
COMMENT ON COLUMN dbo.hotel.preco IS 'Preco da diaria hotel';
COMMENT ON COLUMN dbo.hotel.classificacao IS 'Classificacao do hotel Ex: 2 estrelas';
COMMENT ON COLUMN dbo.hotel.descricao IS 'Descricao do hotel';

COMMENT ON TABLE dbo.viagem IS 'Entidade que armazena as informações das viagens';
COMMENT ON COLUMN dbo.viagem.id IS 'Identificador único da entidade';
COMMENT ON COLUMN dbo.viagem.id_hotel IS 'Identificador da Entidade Hotel que realiza o relacionamento com a Entidade Viagem';
COMMENT ON COLUMN dbo.viagem.data_viagem IS 'Data que foi feita a viagem';
COMMENT ON COLUMN dbo.viagem.quantidade_pessoas IS 'Quantidade de pessoas na viagem';
COMMENT ON COLUMN dbo.viagem.modalidade_viagem IS 'Modalidade da viagem realizada. Ex: First Class, Business Class';

# --- !Downs

DROP SCHEMA dbo;
