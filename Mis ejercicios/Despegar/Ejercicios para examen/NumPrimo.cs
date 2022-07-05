namespace Ejercicios_para_examen
{
    public class NumPrimo
    {
        
       public bool Retornar_Primo(int mnumero)
        {
            for (int i = 2; i < mnumero; i++)
            {
                
                if ((mnumero %i)==0)
                {   
                    //No es primo
                    return false;
                }
                }
            //Si lo es 
            return true;
        }
    }
}