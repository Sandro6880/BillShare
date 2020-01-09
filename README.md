# BillShare (Domainname: BillShare)
Beschreibung vom Projekt.  
Das ist eine neue Zeile.  
Eine Auflistung kann wie gefolgt
erstellt werden:  
+ **Schritt1:**
+ **Schritt2:**
+ *Schritt3:*  

Ein Programmabschnitt kann auch 
eingef�gt werden. Dazu verwende folgende
Syntax:  
```csharp
public class Person
{
    public string Firstname {get;set;}
}
```

## Projektstruktur erstellen
+ **Schritt 1**  
Projektname �berlegen und mit diesem
Namen eine 'Solution' erstellen
+ **Schritt 2**  
Eine Klassenbibliothek 'CommmonBase' erstellen. In dieser Bibliothek werden alle Algorithmen, welche unabh�ngig vom Domain-Bereich sind, gesammelt.  
+ **Schritt 3**  
Eine Klassenbibliothek f�r die Schnittstellen anlegen. Der Projektname wird wie folgt definiert: [Domainname].Contracts.  
+ **Schritt 4**  
EIne Klassenbibliothek f�r die Gesch�ftslogik. In diesem Projekt werden alle Gesch�ftsprozesse gesammelt. Projektname wird wie folgt definiert:[Domainname].Logic  
+ **Schritt 5**  
Erstellen einer Konsolenanwendung zum Testen der Struktur. Projektname wird wie folgt definiert: [Domainname].ConApp  
**Hinweis:** Im weiterem Ausbau werde noch weitere Projekte hinzugef�gt (z.B: Rest-Service).
+ **Schritt 6**  
Abh�ngigkeiten definieren.
## Projekt: Schnittstellen

### Schnittstellen definieren

![Schnittstellen](Contracts.png)

##Projekt: Logik

### Entit�ten definieren
![Entit�ten](Entities.png)

### Weitere Aktionen

Folgende NuGet-Packages hinzuf�gen:
+ **Microsoft.EntityFrameworkCore**
+ **Microsoft.EntityFrameworkCore.SqlServer**
+ **Microsoft.EntityFrameworkCore.Tools**

Wenn die Migration verwendet wird, dann muss zur Konsolen-Anwendung das folgende
  Nuget-Paket hinzugef�gt werden: 
+ **Microsoft.EntityFrameworkCore.Design**
