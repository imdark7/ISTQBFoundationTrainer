INSERT INTO [Questions] (Id,EnglishText,RussianText,Resource,Theme)
Values (1, 'How many test cases are required to cover 100% 0 - switch coverage respectively from X2?
Exhibit:',N'Сколько тест-кейсов необходимо для 100% покрытия методом 0-switch из Х2?','q1',NULL),
(2,'From a Testing perspective, what are the MAIN purposes of Configuration Management?: 
i) Identifying the version of software under test. 
ii) Controlling the version of testware items. 
iii) Developing new testware items. 
iv) Tracking changes to testware items. 
v) Analysing the need for new testware items.',N'С точки зрения тестирования, какие ГЛАВНЫЕ цели для Управления Конфигурацией?
i. Идентифицировать версию для тестируемого ПО
ii. Управление версиями объектов тестового окружения
iii. Разработка новых объектов тестового окружения
iv. Отслеживание изменений в объектах тестового окружения
v. Анализ необходимости использования новых объектов тестового окружения
',NULL,NULL),
 (3,'Which of the following is a MAJOR task of test planning?',N'Что из перечисленного является ГЛАВНОЙ задачей планирования тестирования?',NULL,NULL)

 INSERT INTO [Answers] (Id,QuestionId,EnglishText,RussianText,IsCorrect) VALUES 
 (1,1,'4','4',0),
 (2,1,'1','1',0),
 (3,1,'3','3',0),
 (4,1,'2','2',1),
 (5,2,'ii, iv, v',N'ii, iv, v',0),
 (6,2,'ii, iii and iv',N'ii, iii и iv',0),
 (7,2,'i, ii and iv',N'i, ii и iv',1),
 (8,2,'i, iii and v',N'i, iii и v',0),
 (9,3,'Scheduling test analysis and design tasks.',N'Планирование тест анализа и проектирование задач',1),
 (10,3,'Initiating corrective actions.',N'Инициация правок',0),
 (11,3,'Monitoring progress and test coverage.',N'Мониторинг прогресса и тестового покрытия',0),
 (12,3,'Measuring and analyzing results.',N'Измерение и анализ результатов',0)