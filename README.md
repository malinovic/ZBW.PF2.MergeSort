# Merge Sort

Dieses Programm demonstriert den **Merge Sort**-Algorithmus – ein rekursives Sortierverfahren nach dem Prinzip „Teile und herrsche" (Divide and Conquer).

## Funktionsweise

1. **Teilen** – Das Array wird rekursiv in zwei Hälften aufgeteilt, bis jede Teilmenge nur noch ein Element enthält (ein einzelnes Element ist per Definition sortiert).
2. **Zusammenführen** – Die sortierten Teilmengen werden schrittweise wieder zusammengeführt (`Merge`), wobei die Elemente dabei in die richtige Reihenfolge gebracht werden.

## Beispiel

```
Vorher:  38, 27, 43, 3, 9, 82, 10
Nachher: 3, 9, 10, 27, 38, 43, 82
```

## Komplexität

| | Wert |
|---|---|
| Zeitkomplexität | O(n log n) |
| Speicherkomplexität | O(n) |

Merge Sort ist stabil und liefert unabhängig von der Eingabe immer O(n log n) – also auch im schlechtesten Fall.
