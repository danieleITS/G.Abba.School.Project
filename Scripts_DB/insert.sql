--classi
INSERT INTO public.classi(
	anno,sezione)
	VALUES 
	('1','A'),
	('2','A'),
	('3','A'),
	('4','A'),
	('5','A'),
	('1','B'),
	('2','B'),
	('3','B'),
	('4','B'),
	('5','B'),
	('1','C'),
	('2','C'),
	('3','C'),
	('4','C'),
	('5','C'),
	('1','D'),
	('2','D'),
	('3','D'),
	('4','D'),
	('5','D');

--materie
INSERT INTO public.materie(
	materia)
	VALUES 
	('Matematica'),
	('Italiano'),
	('Storia'),
	('Filosofia'),
	('Fisica'),
	('Scienze'),
	('Religione'),
	('Educazione Fisica'),
	('Programmazione'),
	('Informatica'),
	('Diritto'),
	('Ragioneria'),
	('Economia Aziendale'),
	('Economia Politica');

--studenti
INSERT INTO public.studenti(
	matricola, cognome, nome, sezione_classe, anno_classe, anno_immatricolazione)
	VALUES 
	('A20S01', 'Amarante', 'Gennaro','A','1','2020-01-01'),
	('A18S01', 'Barchi', 'Martin','D','5','2016-01-01'),
	('A20S02', 'Bini', 'Samuele','A','1','2020-01-01'),
	('A18S02', 'Borda', 'Lorenzo','C','1','2016-01-01'),
	('A20S03', 'Borioli', 'Raffaella','A','1','2020-01-01'),
	('A16S01', 'Burioni', 'Gionata','A','2','2016-01-01'),
	('A16S02', 'Carratino', 'Davide','A','1','2016-01-01'),
	('A20S04', 'Cogorno', 'Emir','B','1','2020-01-01'),
	('A20S05', 'Deidda', 'Edoardo','A','1','2020-01-01'),
	('A18S03', 'Gerbi', 'Diego','A','1','2016-01-01'),
	('A18S04', 'Landi', 'Davide','B','1','2016-01-01'),
	('A18S05', 'Lisci', 'Fabrizio','A','2','2016-01-01'),
	('A16S03', 'Manfrin', 'Loris','A','1','2016-01-01'),
	('A20S06', 'Marino', 'Carlotta','A','1','2020-01-01'),
	('A20S07', 'Matei', 'Florin','B','1','2020-01-01'),
	('A20S08', 'Onida', 'Daniele','A','2','2020-01-01'),
	('A20S09', 'Piana', 'Matteo','A','4','2020-01-01'),
	('A16S04', 'Ravecca', 'Francesco','D','1','2016-01-01'),
	('A16S05', 'Sisti', 'Federico','A','1','2016-01-01'),
	('A18S06', 'Stefano', 'Laura','C','3','2018-01-01'),
	('A16S06', 'Traverso', 'Gabriele','A','1','2016-01-01'),
	('A20S10', 'Zambarelli', 'Samuele','A','1','2020-01-01');

--voti
INSERT INTO public.voti(
	matricola, materia, voto)
	VALUES
	('A20S01', 'Fisica', '3'),
	('A18S01', 'Filosofia', '3'),
	('A20S02', 'Italiano', '3'),
	('A18S02', 'Fisica', '3'),
	('A20S03', 'Matematica', '3'),
	('A16S01', 'Filosofia', '8'),
	('A16S02', 'Italiano', '8'),
	('A20S04', 'Scienze', '5'),
	('A20S05', 'Scienze', '5'),
	('A18S03', 'Informatica', '6'),
	('A18S04', 'Programmazione', '6'),
	('A18S05', 'Diritto', '8'),
	('A16S03', 'Diritto', '4'),
	('A20S06', 'Informatica', '7'),
	('A20S07', 'Programmazione', '7'),
	('A20S08', 'Informatica', '6'),
	('A20S09', 'Programmazione', '7'),
	('A16S04', 'Programmazione', '5'),
	('A16S05', 'Programmazione', '9'),
	('A18S06', 'Diritto', '9'),
	('A16S06', 'Programmazione', '6'),
	('A20S10', 'Programmazione', '4');
	