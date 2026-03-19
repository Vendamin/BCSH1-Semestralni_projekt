# BCSH1 Semestrální projekt

* **Autor**: Václav Vellek (st76177)
* **Varianta**: A
* **Téma:** Skladový systém

## Sledované entity

* **SkladováPozice (Lokace):**
  * **Rada** (Značení řady, např. A, B, C...).
  * **Regal** (Číslo sloupce/regálu v dané řadě).
  * **Patro** (Výšková úroveň v regálu).
  * **Stav** (Informace, zda je pozice volná, obsazená nebo poškozená).
* **Paleta (Zboží):**
  * **ID_Palety** (ID).
  * **Obsah** (Stručný popis zboží na paletě).
  * **PocetKusu** (Množství balení/boxů na paletě).
  * **Hmotnost** (Celková hmotnost).
* **SkladovyPohyb (Historie):**
  * **ID_Pohybu** (Primární klíč).
  * **Typ** (Příjem, Výdej, Přesun v rámci skladu).
  * **DatumCas** (Časové razítko operace).
  * **Poznamka** (Doplňující info k manipulaci).

## Vazby
* **Paleta a SkladováPozice (1:1)**: 
  * Každá konkrétní paleta je v jeden okamžik přiřazena právě jedné skladové pozici. Pokud je pozice obsazena, nelze na ni umístit další paletu, dokud se neuvolní.
* **SkladováPozice a SkladovýPohyb (1:N)**: 
  * K jedné pozici se může vázat historie mnoha pohybů.
* **Paleta a SkladovýPohyb (1:N)**: 
  * Každá paleta za svou existenci v systému může projít několika pohyby (příjem -> přesun na jinou pozici -> výdej).

## Funkcionality

* **Správa skladu (CRUD)**: 
  * Plná administrace palet a skladových pozic (vytvoření nové pozice, úprava informací, smazání záznamu).
* **Adresné vyhledávání**: 
  * Okamžité vyhledání palety podle ID s výpisem přesné lokace.
* **Filtrace obsazenosti**: 
  * Zobrazení všech volných pozic pro naskladnění nebo naopak seznamu všech obsazených míst v konkrétní řadě.
* **Logika přesunu**: 
  * Funkce pro fyzický přesun palety mezi regály (automaticky uvolní starou pozici a obsadí novou).
* **Příjem a Výdej**: 
  * Rychlé formuláře pro naskladnění nové palety a její trvalé odstranění ze systému při expedici.

## Technologie
* **Vývojové prostředí**: C# / .NET 9.0
* **GUI**: Windows Forms (WinForms)
* **Databáze**: SQLite