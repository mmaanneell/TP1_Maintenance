# TP1 Maintenance - Guide d'exécution


## Comment exécuter l'application

###  Depuis la ligne de commande

1. Ouvrez un terminal PowerShell
2. Naviguez vers le dossier du projet principal :


cd "c:\VOTRE-CHEMIN\TP1_Maintenance\TP1Maintenance"


3. Compilez et exécutez l'application :

dotnet run


## Comment exécuter les tests unitaires


### Depuis la ligne de commande

#### Exécuter tous les tests

cd "c:\VOTRE-CHEMIN\TP1_Maintenance\TP1MaintenanceTests"
dotnet test


#### Exécuter un test spécifique

exemple:
dotnet test --filter "Constructor_WithValidParameters"


#### Exécuter tous les tests d'une classe

dotnet test --filter "EmployeeTests"






