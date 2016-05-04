CREATE TABLE [dbo].[Animal] (
  [IdAnimal] INT IDENTITY (1,1) NOT NULL,
  [Name] VARCHAR(50) NULL,
  [Age] INT NULL,
  [IdHabitat] INT NULL,
  [IdGenus] INT NULL,
  [IdSpecies] INT NULL
  PRIMARY KEY CLUSTERED ([IdAnimal] ASC)
);

CREATE TABLE [dbo].[Genus] (
  [IdGenus] INT IDENTITY (1,1) NOT NULL,
  [ScientificName] VARCHAR(50) NULL,
  PRIMARY KEY CLUSTERED ([IdGenus] ASC)
);

CREATE TABLE [dbo].[Species] (
  [IdSpecies] INT IDENTITY (1,1) NOT NULL,
  [CommonName] VARCHAR(50) NULL,
  [ScientificName] VARCHAR(50) NULL,
  [Url] VARCHAR(50) NULL,
  [IdGenus] INT NULL,
  PRIMARY KEY CLUSTERED ([IdSpecies] ASC)
);

CREATE TABLE [dbo].[Habitat] (
  [IdHabitat] INT IDENTITY (1,1) NOT NULL,
  [Name] VARCHAR(50) NULL,
  [CurrentlyOpen] BIT NULL,
  [IdHabitatType] INT NULL,
  [IdEmployee] INT NULL,
  PRIMARY KEY CLUSTERED ([IdHabitat] ASC)
);

CREATE TABLE [dbo].[HabitatType] (
  [IdHabitatType] INT IDENTITY (1,1) NOT NULL,
  [Name] VARCHAR(50) NULL,
  PRIMARY KEY CLUSTERED ([IdHabitatType] ASC)
);

CREATE TABLE [dbo].[Employee] (
  [IdEmployee] INT IDENTITY (1,1) NOT NULL,
  [Name] VARCHAR(50) NULL,
  [Age] INT NULL,
  PRIMARY KEY CLUSTERED ([IdEmployee] ASC)
);

ALTER TABLE Animal
ADD CONSTRAINT [FK_Animal_IdHabitat]
FOREIGN KEY ([IdHabitat])
REFERENCES [dbo].[Habitat] ([IdHabitat]);

ALTER TABLE Animal
ADD CONSTRAINT [FK_Animal_IdGenus]
FOREIGN KEY ([IdGenus])
REFERENCES [dbo].[Genus] ([IdGenus]);

ALTER TABLE Animal
ADD CONSTRAINT [FK_Animal_IdSpecies]
FOREIGN KEY ([IdSpecies])
REFERENCES [dbo].[Species] ([IdSpecies]);

ALTER TABLE Species
ADD CONSTRAINT [FK_Species_IdGenus]
FOREIGN KEY ([IdGenus])
REFERENCES [dbo].[Genus] ([IdGenus]);

ALTER TABLE Habitat
ADD CONSTRAINT [FK_Habitat_IdHabitatType]
FOREIGN KEY ([IdHabitatType])
REFERENCES [dbo].[HabitatType] ([IdHabitatType]);

ALTER TABLE Habitat
ADD CONSTRAINT [FK_Habitat_IdEmployee]
FOREIGN KEY ([IdEmployee])
REFERENCES [dbo].[Employee] ([IdEmployee]);