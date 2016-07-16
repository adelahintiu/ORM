---insert in Localitate

INSERT INTO Colectie.Localitate (Denumire, JudetId, Cod)
VALUES ('Campulung',	1,	10)

INSERT INTO Colectie.Localitate (Denumire, JudetId, Cod)
VALUES ('Sibiu', 4, 55)

INSERT INTO Colectie.Localitate (Denumire, JudetId, Cod)
VALUES ('Bucuresti', 2, 99)

INSERT INTO Colectie.Localitate (Denumire, JudetId, Cod)
VALUES ('Alba Iulia', 3, 98)

select * from Colectie.Localitate

---insert in Muzeu

INSERT INTO Colectie.Muzeu (Denumire, NumarStele, BilantViziteId, LocalitateId)
VALUES ('Muzeul Taranului Roman', 2, 3, 1)

INSERT INTO Colectie.Muzeu (Denumire, NumarStele, BilantViziteId, LocalitateId)
VALUES ('BRUKENTHAL', 5, 3, 3)


INSERT INTO Colectie.Muzeu (Denumire, NumarStele, BilantViziteId, LocalitateId)
VALUES ('Muzeul National al Unirii', 4, 1, 2)


INSERT INTO Colectie.Muzeu (Denumire, NumarStele, BilantViziteId, LocalitateId)
VALUES ('Grigore Antipa', 5, 2, 4)

---insert in BilantVizite

INSERT INTO Colectie.BilantVizite (NumarVizite, Data)
VALUES (500, '2016-07-10')

INSERT INTO Colectie.BilantVizite (NumarVizite, Data)
VALUES (345, '2016-07-09')

INSERT INTO Colectie.BilantVizite (NumarVizite, Data)
VALUES (899, '2016-07-14')

INSERT INTO Colectie.BilantVizite (NumarVizite, Data)
VALUES (123, '2016-07-05')

---insert in ProfilGeneral

INSERT INTO Colectie.ProfilGeneral (Denumire)
VALUES ('Arheologie')


INSERT INTO Colectie.ProfilGeneral (Denumire)
VALUES ('Etnografie')


INSERT INTO Colectie.ProfilGeneral (Denumire)
VALUES ('Biologic')



---insert in MuzeuProfil
INSERT INTO Colectie.MuzeuProfilGeneral (MuzeuId, ProfilGeneralId)
VALUES (2, 2)

INSERT INTO Colectie.MuzeuProfilGeneral (MuzeuId, ProfilGeneralId)
VALUES (3, 3)


INSERT INTO Colectie.MuzeuProfilGeneral (MuzeuId, ProfilGeneralId)
VALUES (5, 4)


INSERT INTO Colectie.MuzeuProfilGeneral (MuzeuId, ProfilGeneralId)
VALUES (4, 1)