public List<string> FizzBuzz(int n){
    List<string> results = new List<string>()
    for(int i =1, fizz = 0; buzz =0; i++){
        fizz++;
        buzz++;
        if(fizz == 3 && buzz == 5){
            results.Add("FizzBuzz");
            fizz = 0;
            buzz = 0;
         else if(fizz == 3){
             results.Add("Fizz");
             fizz = 0;
         }
         else if(buzz == 5){
             results.Add("Buzz");
             buzz = 0;
         }
        }else{
            result.Add(i.ToString());
        }
        return results;                 
        }
    }