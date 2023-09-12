using System;

namespace StackClass {    
    public class Stack {
        
        static readonly int MAX = 1000;
        int top = -1;
        string[] pilhaString = new string[MAX];

        public bool IsEmpty() {
            return(top < 0);  
        } 

        public bool Push(string novaString) {
            if (top >= MAX) {
                Console.WriteLine("Stack Overflow");
                return false;
            }
            top +=1;
            pilhaString[top] = novaString;
            return true;
        }

        public string Pop() {
            if (top < 0) {
                Console.WriteLine("Stack Underflow");
                return "Erro";
            }
            string valor = pilhaString[top];
            top -= 1;
            return valor;
        }

        public void Peek() {
            if (top < 0) {
                Console.WriteLine("Stack Underflow");
                return;
            }

            Console.WriteLine($"O topo da pilha é: {pilhaString[top]}");
        }

        public void PrintStack() {

            if (top < 0) {
                Console.WriteLine("Stack Underflow");
                return;
            }

            Console.WriteLine("Itens da pilha:");
            for (int i = top; i >= 0; i--) {
                string texto = $"Stack: [{pilhaString[i]}]";
                Console.WriteLine(texto);
            }
        }
    }
}