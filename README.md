# Fraction Application

Place your UML diagram here !

Class:
Fraction

Atributes:
- numerator: int    #top number 
- denominator: int  #bottom number

Methods:
+ Fraction()    # 1/1
+ Fraction(numerator: int, denominator: int)
+ ToString(): string   #vb 1/2
+ Result(): double     #vb 0.5
+ Add(right: Fraction): Fraction # 1/2 + 1/2 -> 2/2
+ Multiply(right: Fraction): Fraction # 1/2 * 1/2 -> 1/4 or 2/4 * 3/2   
+ Subtract(right: Fraction): Fraction # 1/2 - 1/2 -> 1/2 + (-1/2) -> 0/2
+ Divide(right: Fraction): Fraction # 1/2 / 1/2 -> 1/2 * (2/1) -> 2/2
+ Reciprocal(): Fraction # 1/2 -> 2/1
+ Invert(): Fraction     # 1/2 -> -1/2
+ Simplify(): Fraction   # 2/4 -> 1/2

Notes:
If something leads to a exeption, just do nothing and return the original fraction.