# Simple Python Program
# This program demonstrates basic programming concepts:
# variables, loops, conditionals, and functions.
# Created with assistance from Microsoft Copilot.

# Function to greet the user
def greet(name):
    print("Hello,", name, "! Welcome to the program.")

# Function to check if a number is even or odd
def check_even_odd(number):
    if number % 2 == 0:
        print(number, "is even.")
    else:
        print(number, "is odd.")

# Main program
def main():
    # Variable example
    user_name = input("Enter your name: ")
    greet(user_name)

    # Loop example
    print("\nLet's check numbers from 1 to 5:")
    for i in range(1, 6):
        check_even_odd(i)

# Run the program
if __name__ == "__main__":
    main()
