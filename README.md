# TP1_Maintenance

ReadMe - CodeSmells

Program.cs
Conventions de C# – Une classe par fichier & God Class
Program.cs contient la majorité des classes dans un seul fichier. La classe Program, qui contient le Main, ne doit pas être bombardée par des classes qui ne lui appartiennent pas et elle exerce trop de responsabilités. Cette méthode de travail la rend lourde, illisible et ne respecte pas une logique ni une cohérence. Ainsi, les classes suivantes ont été déplacées dans de nouveaux fichiers :
•	Enum SchoolMemberType → SchoolMemberType.cs
•	AcceptAttributes → ActionAdd.cs
•	acceptChoices → MenuHelper.cs
•	acceptMemberType → MenuHelper.cs
•	addPrincipal → ActionAdd.cs
•	addStudent → ActionAdd.cs
•	addTeacher → ActionAdd.cs
•	Add → ActionAdd.cs
•	Display → ActionDisplay.cs
•	Pay → ActionPay.cs
•	RaiseComplaint → Receptionist.cs
•	HandleComplaintRaise → Receptionist.cs
•	ShowPerformance → Student.cs

Refactor – Conventions générales
•	Appliquer PascalCase / camelCase aux bons endroits
•	Ajouter des propriétés / champs privés
•	Les accolades doivent être sur des lignes séparées
•	Enlever les « var » et les remplacer par le bon type
•	Enlever les nombres magiques (les remplacer par des constantes)
•	S’assurer que les méthodes commencent par des verbes
•	Enlever les commentaires inutiles
•	Renommer toutes les méthodes fautives de manière convenable

Code Smells – Contrôle de flux : Switch Statement
Il se trouvait un switch case imposant à l’intérieur du Main qui contrôlait l’entièreté de l’interaction que l’utilisateur a avec le programme. Ce Code Smell est l’un des seuls qui peuvent être justifiables. Mais, dans notre programme, nous avons tout de même décidé de créer une interface Choice(), qui se trouve dans une directive nommée Actions, et qui contrôle la manière dont l’utilisateur peut interagir avec notre programme. La raison de cette modification est que notre équipe trouvait que le switch case encombrait visuellement le Main. De plus, nous voulions éliminer le plus de Code Smells possible.

Code Smells – Gestion des erreurs et lisibilité : Commentaires
Nous avons retiré tous les commentaires complètement inutiles dans le fichier. Voici les commentaires qui ont été supprimés :
// Just for manual testing purposes.
// Console.WriteLine("Please enter the Principal's information.");
// AddPrincipal();



-----------------------------------------------------



Teacher.cs
Refactor – Conventions de C#
•	Appliquer PascalCase / camelCase aux bons endroits
•	Ajouter des propriétés / champs privés
•	Les accolades doivent être sur des lignes séparées
•	Enlever les « var » et les remplacer par le bon type
•	Enlever les nombres magiques (les remplacer par des constantes)
•	S’assurer que les méthodes commencent par des verbes
•	Enlever les commentaires inutiles
•	Renommer toutes les méthodes fautives de manière convenable

Student.cs
Refactor – Conventions de C#
•	Appliquer PascalCase / camelCase aux bons endroits
•	Ajouter des propriétés / champs privés
•	Les accolades doivent être sur des lignes séparées
•	Enlever les « var » et les remplacer par le bon type
•	Enlever les nombres magiques (les remplacer par des constantes)
•	S’assurer que les méthodes commencent par des verbes
•	Enlever les commentaires inutiles
•	Renommer toutes les méthodes fautives de manière convenable

Receptionist.cs
Refactor – Conventions de C#
•	Appliquer PascalCase / camelCase aux bons endroits
•	Ajouter des propriétés / champs privés
•	Les accolades doivent être sur des lignes séparées
•	Enlever les « var » et les remplacer par le bon type
•	Enlever les nombres magiques (les remplacer par des constantes)
•	S’assurer que les méthodes commencent par des verbes
•	Enlever les commentaires inutiles
•	Renommer toutes les méthodes fautives de manière convenable

Code Smell – Une classe par fichier
Il se trouvait une classe inline nommée Complaint : EventArgs à l’intérieur du fichier de la classe Receptionist. Cette classe a été déplacée dans son propre fichier → Complaint.cs avec toutes ses méthodes.
La seule méthode liée aux plaintes qui reste dans Receptionist est HandleComplaint(), car cette méthode lui est propre et fait partie de son travail.

Principal.cs
Refactor – Conventions de C#
•	Appliquer PascalCase / camelCase aux bons endroits
•	Ajouter des propriétés / champs privés
•	Les accolades doivent être sur des lignes séparées
•	Enlever les « var » et les remplacer par le bon type
•	Enlever les nombres magiques (les remplacer par des constantes)
•	S’assurer que les méthodes commencent par des verbes
•	Enlever les commentaires inutiles
•	Renommer toutes les méthodes fautives de manière convenable

Directive Members
Code Smells – Chirurgie au fusil
Nous avons créé deux nouveaux fichiers dans la directive Members pour corriger la « chirurgie au fusil » dans les quatre membres : SchoolMember.cs et Employee.cs.
SchoolMember utilise le polymorphisme pour définir les traits de base que tous les membres devraient avoir.
Ex. : Name, Address, PhoneNumber et l’action Display().
Employee utilise le polymorphisme pour définir les traits que les employés d’une école (directeur, réceptionniste, professeur) peuvent avoir.
Ex. : Income, Balance et l’action Pay().
Ainsi, les classes Receptionist, Student, Teacher et Principal héritent de ces deux autres classes et de leurs méthodes afin d’éviter la duplication des mêmes attributs.
