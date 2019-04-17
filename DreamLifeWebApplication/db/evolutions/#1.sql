# --- !Ups
CREATE SCHEMA mytrips;

CREATE TABLE mytrips.cidade(
	id SERIAL NOT NULL,
	nome CHARACTER VARYING(255),
	pais CHARACTER VARYING(255),
	CONSTRAINT pk_cidade PRIMARY KEY(id)
);

CREATE TABLE mytrips.hotel(
	id SERIAL NOT NULL, 
	nome CHARACTER VARYING(255),
	id_cidade INTEGER NOT NULL,
	preco DOUBLE PRECISION,
    classificacao INTEGER,
    descricao TEXT,	
	CONSTRAINT pk_hotel PRIMARY KEY(id),
	CONSTRAINT fk_h_cidade FOREIGN KEY (id_cidade) REFERENCES mytrips.cidade(id)
);

CREATE TABLE mytrips.viagem(
	id SERIAL NOT NULL,
	id_hotel INTEGER NOT NULL,
	data_viagem DATE,
	quantidade_pessoas INTEGER,
	modalidade_viagem VARCHAR(100),
	CONSTRAINT pk_viagem PRIMARY KEY(id),
	CONSTRAINT fk_v_hotel FOREIGN KEY(id_hotel) REFERENCES mytrips.hotel(id) 
);

COMMENT ON TABLE mytrips.cidade IS 'Entidade responsável por armazenar as informações das cidades';
COMMENT ON COLUMN mytrips.cidade.id IS 'Identificador único da entidade';
COMMENT ON COLUMN mytrips.cidade.nome IS 'Nome da cidade';
COMMENT ON COLUMN mytrips.cidade.esrado IS 'Estado da cidade Ex: MG, SP, ...';

COMMENT ON TABLE mytrips.hotel IS 'Entidade responsável por armazenar as informações de hoteis cadastrados';
COMMENT ON COLUMN mytrips.hotel.id IS 'Identificador único da entidade';
COMMENT ON COLUMN mytrips.hotel.nome IS 'Nome do hotel';
COMMENT ON COLUMN mytrips.hotel.id_cidade IS 'Identificador da Entidade Cidade que realiza o relacionamento com a Entidade Hotel';
COMMENT ON COLUMN mytrips.hotel.preco IS 'Preco da diaria hotel';
COMMENT ON COLUMN mytrips.hotel.classificacao IS 'Classificacao do hotel Ex: 2 estrelas';
COMMENT ON COLUMN mytrips.hotel.descricao IS 'Descricao do hotel';

COMMENT ON TABLE mytrips.viagem IS 'Entidade que armazena as informações das viagens';
COMMENT ON COLUMN mytrips.viagem.id IS 'Identificador único da entidade';
COMMENT ON COLUMN mytrips.viagem.id_hotel IS 'Identificador da Entidade Hotel que realiza o relacionamento com a Entidade Viagem';
COMMENT ON COLUMN mytrips.viagem.data_viagem IS 'Data que foi feita a viagem';
COMMENT ON COLUMN mytrips.viagem.quantidade_pessoas IS 'Quantidade de pessoas na viagem';
COMMENT ON COLUMN mytrips.viagem.modalidade_viagem IS 'Modalidade da viagem realizada. Ex: First Class, Business Class';

# --- !Downs

DROP SCHEMA mytrips;
