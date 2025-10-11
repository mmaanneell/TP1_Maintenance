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



____________________________________________________________



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

Validation – Null check
Faire la validation du constructeur SchoolMember et Employee
•	S’assurer que toutes les l’entrés ne sont pas nulle ou un espace. 
•	S’assurer que Income ne peut pas être un nombre négatif.



_____________________________________________________



Directive Helper
NetworkDelay.cs
NetworkDelay a complètement été éradiqué de notre code puisqu’il ne nous servait à rien d’autre que de simuler des délais. Nous ne voyons pas son utilité.

ConsoleHelper.cs
Validation – Null check & FailSafe / FailSoft
Validation de la méthode AskInfoInput()
•	S’assurer que l’entrée n’est pas nulle ou un espace.
Validation de la méthode AskNumberInput()
•	S’assurer que le chiffre est plus grand que 0.
•	S’assurer que l’entrée n’est pas nulle ou un espace.

Refactor – Conventions de C#
•	Changer les méthodes pour qu’elles commencent par des verbes.
•	Changer le nom des méthodes pour qu’elles soient plus représentatives de leur fonction.


Creation de MenuHelper.cs pour contenir les méthodes AcceptChoices() et AcceptMembertype()


______________________________________________________________

Directive Root
La directive root a été renommé pour avoir un nom plus représentatif : Managers.

Payroll n’existe plus après la l’utilisation du polymorphisme dans employees. Payroll n’est donc plus nécessaire.

SchoolMember.cs à été déplacé à l’intérieur de la directive Members.


UndoEntry & UndoManager sont deux nouvelles classes dans la directive, ajoutées pour intégrer la fonctionnalité Undo.






MISC

-	Toutes les classes ayant des noms divergents ont été renommé pour avoir le mem nom que leur fichier.
-	Tous les noms des NameSpaces partage le même nom que leur directive.


