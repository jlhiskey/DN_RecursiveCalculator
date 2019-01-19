
# C# Recursive Calculator
 - This calculator enables a user to perform basic math functions.
   - Add: A + B
   - Subtract: A - B
   - Multiply: A * B
   - Divide: A/B
   - nthRoot: Bth Root of A
   - Exponent: A ^ B
    
 - This calculator is powered by recursion.
   - Be warned that performing large calculations with this calculator will punish you stack ;)
   
 - Good Luck...

## Specs
- This calculator has 6 calculation methods and 1 calculator method.
### Calculator Method
    static void Calculator(int a, CalcType calcType, int b )
- This method serves as the interface that a user would use when performing calculations.
#### Inputs:
  - 2 int variables and a enum variable that defines which mathmatic operation you want to perform.
    - Math Operation Enums
      - add
      - subtract
      - multiply
      - divide
      - useRoot
      - useExponent
      
#### Outputs
  - Console message indicating variables used, operator used and solution.
#### Example Usage
       Calculator(4, CalcType.add, 2);
       Calculator(4, CalcType.subtract, 2);
       Calculator(4, CalcType.multiply, 2);
       Calculator(2, CalcType.divide, 2);
       Calculator(3, CalcType.useRoot, 3);
       Calculator(3, CalcType.useExponent, 3);
#### Example Output
       4 + 2 = 6
       4 - 2 = 2
       4 * 2 = 8
       2 / 2 = 1
       3 root of 27 = 3
       3 ^ 3 = 27

### Add Method
    public static int Add(int a, int b)
- This method handles addition operations.
#### Inputs:
  - 2 int variables
    - a + b   
#### Outputs
  - int value
#### Example Usage
       Add(2, 2);
#### Example Output
       4
 #### Limitations
- Currently int b can only be a positive int.
- Only returns whole values.

### Subtract Method
    public static int Subtract(int a, int b)
- This method handles subtraction operations.
#### Inputs:
  - 2 int variables
    - a - b
      
#### Outputs
  - int value
#### Example Usage
       Subtract(2, 2);
#### Example Output
       0
 #### Limitations
- Only returns whole values.
 
### Multiply Method
    public static int Multiply(int a, int b)
- This method handles addition operations.
#### Inputs:
  - 2 int variables
    - a * b   
#### Outputs
  - int value
#### Example Usage
       Multiply(2, 3);
#### Example Output
       6
 #### Limitations
- Currently int b can only be a positive int.
- Only returns whole values.

### Divide Method
    public static int Divide(int a, int b)
- This method handles addition operations.
#### Inputs:
  - 2 int variables
    - a / b   
#### Outputs
  - int value
#### Example Usage
       Divide(4, 2);
#### Example Output
       2
 #### Limitations
- Currently int b can only be a positive int.
- Only returns whole values.

        5 / 2 = 2

### NthRoot Method
    public static int NthRoot(int a, int b)
- This method handles addition operations.
#### Inputs:
  - 2 int variables
    - bth root of a   
#### Outputs
  - int value
#### Example Usage
       NthRoot(27, 3);
#### Example Output
       3
 #### Limitations
- Currently int b can only be a positive int.
- Only returns whole values.

      4 root of 27 = 2

### Exponent Method
    public static int Exponent(int a, int b)
- This method handles addition operations.
#### Inputs:
  - 2 int variables
    - bth root of a   
#### Outputs
  - int value
#### Example Usage
       NthRoot(27, 3);
#### Example Output
       3
 #### Limitations
- Currently int b can only be a positive int.
- Only returns whole values.

