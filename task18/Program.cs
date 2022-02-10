// Задача 18: Проверить истинность утверждения¬(X ⋁ Y) = ¬X ⋀ ¬Y



   void LogicFunction(bool a, bool b)
   {
    
       Console.WriteLine($"{!(a || b)}= {!a && !b}");
   }
   LogicFunction(false, false);
   LogicFunction(false, true);
   LogicFunction(true, false);
   LogicFunction(true, true);

