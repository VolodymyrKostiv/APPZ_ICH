USE ICHDB

INSERT INTO WorkTypes(Title)
VALUES ('³������� ������'), ('ó������'), ('� ����/�� ����');

INSERT INTO Locations(Title)
VALUES ('����'), ('���'), ('�����-���������'), ('��������'), ('�������'), 
('³�����'), ('�������'), ('�������'), ('�����'), ('�����'), ('�����'), ('������');

INSERT INTO UserType(Title)
VALUES ('Admin'), ('Employer'), ('Employee');

INSERT INTO EmploymentTypes(Title)
VALUES ('����� ���������'), ('������� ���������'), ('�������� ������'), ('������� ������');

INSERT INTO SpecialCategories(Title)
VALUES ('����������'), ('��������� ����'), ('����� � ����������'), ('���������');

INSERT INTO Categories(Title)
VALUES ('����� ��������������'), ('������ ������������'), ('��������, �����'), ('���������, �������, HR'), 
('Գ�����, ������'), ('�����, ������, �����'), ('�������������� �� ��''����'), ('��'), ('����������, �����')

INSERT INTO UserInfo([Description], LocationId, Position, CategoryId, 
EmploymentTypeId, WorkTypeId, CreationTime, UserName)
VALUES 
('������ �������', 1, '� �������, ��� �������', 8, 1, 1, '2023-05-20', '����������'),
('������������ �� ��������� ������, �������, 30 ���� ������ ���������', 2, '���������', 1, 4, 3, '2023-10-10', '����'),
('�������', 3, '� ����� ����', 2, 2, 3, '2023-10-10', '���������'),
('Lorem 1', 1, '�����', 2, 1, 3, '2023-10-25', '�������'),
('Lorem 2', 2, 'HR', 4, 1, 3, '2023-10-30', '����'),
('Lorem 3', 3, '���������', 9, 1, 3, '2023-10-25', '������'),
('Lorem 4', 4, '�������', 9, 1, 3, '2023-09-25', '�����'),
('Lorem 5', 5, '��������', 1, 1, 3, '2023-10-05', '�����'),
('Lorem 6', 5, '��������', 1, 1, 3, '2023-10-05', 'IPhone'),
('Lorem 7', 3, '���������', 9, 1, 3, '2023-10-25', '�����'),
('Lorem 8', 4, '�������', 9, 1, 3, '2023-09-25', '�������'),
('Lorem 9', 5, '��������', 1, 1, 3, '2023-10-05', '������'),
('Lorem 10', 5, '��������', 1, 1, 3, '2023-10-05', '�����'),
('Lorem 11', 4, '�������', 9, 1, 3, '2023-09-25', '�����'),
('Lorem 12', 5, '��������', 6, 1, 3, '2023-10-05', '����� �������'),
('Lorem 13', 5, '������', 5, 1, 3, '2023-10-05', '�����'),
('Lorem 14', 3, '��������', 4, 1, 3, '2023-10-25', '����� ���������'),
('Lorem 15', 4, '������', 9, 1, 3, '2023-09-25', '������� ������'),
('Lorem 16', 5, '���������', 3, 1, 3, '2023-10-05', '������'),
('Lorem 17', 5, '������� � ����', 2, 1, 3, '2023-10-05', '����� ���������');

INSERT INTO SpecialCategoryUserInfo (SpecialCategoriesSpecialCategoryId, UserInfosUserInfoId)
VALUES (4, 1), (4, 3), (2, 2), (3, 2), (4, 7), (1, 10), (3, 5), (4, 5), (2, 6), (4, 20), (4, 19);

INSERT INTO [Users] ([Login],[Password],UserTypeId, UserInfoId)
VALUES
  ('boss_of_this_gym',				1234,	1, NULL),

  ('non@google.org',				1111,	3, 1),
  ('iaculis.odio@google.couk',		1111,	3, 2),
  ('tellus.sem@icloud.com',			1111,	3, 3),
  ('augue.id@google.edu',			1111,	3, 4),
  ('morbi.tristique@outlook.couk',	1111,	3, 5),
  ('est@outlook.edu',				1111,	3, 6),
  ('orci.luctus@hotmail.com',		1111,	3, 7),
  ('vivamus.sit@protonmail.edu',	1111,	3, 8),
  ('iaculis.enim@icloud.net',		1111,	3, 9),
  ('vel.arcu@protonmail.ca',		1111,	3, 10),
  ('sem.eget@protonmail.org',		1111,	3, 11),
  ('purus.mauris@hotmail.edu',		1111,	3, 12),
  ('at.risus@google.couk',			1111,	3, 13),
  ('a.sollicitudin@protonmail.com',	1111,	3, 14),
  ('mus.aenean@google.couk',		1111,	3, 15),
  ('elit.pretium@outlook.ca',		1111,	3, 16),
  ('placerat.augue@outlook.edu',	1111,	3, 17),
  ('a.sou.orci@protonmail.edu',		1111,	3, 18),
  ('lobortis.quam@outlook.net',		1111,	3, 19),
  ('magna@outlook.edu',				1111,	3, 20),

  ('abto@gmail.com',				0000,	2, NULL),							 
  ('Pascal',						0000,	2, NULL),
  ('ABC',							0000,	2, NULL);

INSERT INTO Vacancies (Title, [Description], LocationId, CreationTime, Salary, 
Company, EmploymentTypeId, UserId, CategoryId, WorkTypeId)
VALUES 
('���������-����������� �������� ������ Sribna Kraina ', '�� ����� ����� �� �������� ��������� �����! ��
�� ����쳺���� �� �������� �������! � �� � ��� ����������� ��������!', 1, '2022-10-10', 12000, 'Union Group ', 2, 23, 4, 3),
('Cashier', 'Are you sociable, friendly, energetic, hardworking and responsible? Then you are the ideal candidate for the position of Cashier of the trading hall in Blyzenko!',
1, '2022-05-02', 11000, 'Blyzenko', 1, 24, 1, 3),
('Store manager', 'Friend, aren''t you "sitting" at your workplace? Maybe it''s time to raise the bar and believe in yourself? Come to us for an interview! A store manager with a desire to develop and grow is urgently needed.',
1, '2022-04-02', 21000, 'Blyzenko', 1, 24, 1, 3),
('Customer service specialist', 'The Lviv contact center is a place of active and ambitious people who provide the best customer support and service! Do you want to work in a cool team, earn well, develop professionally, and also keep up with everything? Join the Vodafone Ukraine team!',
2, '2022-07-10', 16000, 'Vodafone', 1, 23, 2, 3),
('���������', 'The Lviv contact center is a place of active and ambitious people who provide the best customer support and service!',
1, '2022-02-12', 12000, 'BLT', 1, 22, 9, 3),
('Project manager', 'Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Maecenas porttitor congue massa. Fusce posuere, magna sed pulvinar ultricies',
3, '2022-01-19', 78000, 'swIT', 3, 22, 8, 1),
('junior swift dev', 'Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Maecenas porttitor congue massa. Fusce posuere, magna sed pulvinar ultricies',
4, '2022-05-14', 35000, 'swIT', 1, 22, 8, 1),
('Lead Python Dev', 'Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Maecenas porttitor congue massa. Fusce posuere, magna sed pulvinar ultricies',
5, '2022-10-12', 203000, 'swIT', 2, 22, 8, 1),
('Business Analyst', 'Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Maecenas porttitor congue massa. Fusce posuere, magna sed pulvinar ultricies',
6, '2022-11-19', 98000, 'swIT', 4, 22, 8, 2),
('HR', 'Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Maecenas porttitor congue massa. Fusce posuere, magna sed pulvinar ultricies',
6, '2022-11-11', 20000, 'swIT', 4, 22, 4, 3),
('�����', 'Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Maecenas porttitor congue massa. Fusce posuere, magna sed pulvinar ultricies',
8, '2022-03-22', 75000, 'oborTisSTD', 1, 23, 3, 3),
('Գ�������', 'Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Maecenas porttitor congue massa. Fusce posuere, magna sed pulvinar ultricies',
9, '2022-10-23', 40000, 'oborTisSTD', 1, 23, 5, 3),
('Nail master', 'Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Maecenas porttitor congue massa. Fusce posuere, magna sed pulvinar ultricies',
2, '2022-10-21', 20000, 'BeatyKruti', 1, 22, 6, 3),
('Գ���� ������', 'Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Maecenas porttitor congue massa. Fusce posuere, magna sed pulvinar ultricies',
2, '2022-10-25', 25000, 'BBalls', 1, 23, 6, 3),
('�������� Vodaphone', 'Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Maecenas porttitor congue massa. Fusce posuere, magna sed pulvinar ultricies',
2, '2022-10-25', 25000, 'Vodaphone', 1, 22, 7, 3);

INSERT INTO SpecialCategoryVacancy (SpecialCategoriesSpecialCategoryId, VacanciesVacancyId)
VALUES (4, 1), (4, 2), (4, 3), (4, 4), (3, 4), (1, 2), (2, 3), (4, 5), (2, 8), (3, 8), (1, 6), (1, 7)
