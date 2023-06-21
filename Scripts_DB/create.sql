-- Table: public.classi

-- DROP TABLE IF EXISTS public.classi;

CREATE TABLE IF NOT EXISTS public.classi
(
    anno int NOT NULL,
    sezione character varying(5) NOT NULL,
	PRIMARY KEY(anno, sezione)
)

TABLESPACE pg_default;

ALTER TABLE IF EXISTS public.classi
    OWNER to postgres;

GRANT SELECT ON TABLE public.classi TO "Utente_sola_lettura";

GRANT ALL ON TABLE public.classi TO postgres;

/* - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - */ 



-- Table: public.studenti

--DROP TABLE IF EXISTS public.studenti;

CREATE TABLE IF NOT EXISTS public.studenti
(
    matricola character varying(20) COLLATE pg_catalog."default" NOT NULL,
    nome character varying(20) COLLATE pg_catalog."default" NOT NULL,
    cognome character varying(20) COLLATE pg_catalog."default" NOT NULL,
    anno_classe int,
    sezione_classe character varying(5),
    anno_immatricolazione date not null,
    CONSTRAINT studenti_pkey PRIMARY KEY (matricola),
    FOREIGN KEY(anno_classe,sezione_classe) REFERENCES classi(anno,sezione)
)

TABLESPACE pg_default;

ALTER TABLE IF EXISTS public.studenti
    OWNER to postgres;

GRANT SELECT ON TABLE public.studenti TO "Utente_sola_lettura";

GRANT ALL ON TABLE public.studenti TO postgres;

/* - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - */ 



-- Table: public.materie

--DROP TABLE IF EXISTS public.materie;

CREATE TABLE IF NOT EXISTS public.materie
(
    materia varchar(20) NOT NULL,
    PRIMARY KEY(materia),
    UNIQUE(materia)
)

TABLESPACE pg_default;

ALTER TABLE IF EXISTS public.materie
    OWNER to postgres;

GRANT SELECT ON TABLE public.materie TO "Utente_sola_lettura";

GRANT ALL ON TABLE public.materie TO postgres;

/* - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - */ 


-- Table: public.voti

--DROP TABLE IF EXISTS public.voti;

CREATE TABLE IF NOT EXISTS public.voti
(
    IDvoto SERIAL,
    matricola varchar(20) NOT NULL,
    materia varchar(20) NOT NULL,
    voto varchar(20) NOT NULL,
	PRIMARY KEY(IDvoto),
    FOREIGN KEY (matricola) REFERENCES studenti(matricola),
    FOREIGN KEY (materia) REFERENCES materie(materia)
)

TABLESPACE pg_default;

ALTER TABLE IF EXISTS public.voti
    OWNER to postgres;

GRANT SELECT ON TABLE public.voti TO "Utente_sola_lettura";

GRANT ALL ON TABLE public.voti TO postgres;