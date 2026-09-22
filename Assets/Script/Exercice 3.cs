using UnityEngine;


public class Exercice3 : MonoBehaviour
{
    //variable
    public GameObject A;//cube
    public GameObject B;//sphére
    public GameObject C;//cylindre


    public GameObject mon_preferer;
    public GameObject choisi;
    public GameObject new_GO;


    public int start = Random.Range(0, 3);
    public int choix = Random.Range(0, 3);
    public int starter = 0;

    //au démarage
    void Start()
    {
        start = Random.Range(0, 3);
        //choisir au hasard mon preferer au debut
        if (start == 0)
        {
            mon_preferer = A;
        }
        if (start == 1)
        {
            mon_preferer = B;
        }
        if (start == 2)
        {
            mon_preferer = C;
        }
        print("mon preferer au start est =" + mon_preferer);

        //faire Itérer 10 000 fois
        for (int i = 0; i < 10000; i++)
        {
            choix = Random.Range(0, 3);//choix 1 des 3 Game Object

            if (choix == 0 && mon_preferer != A)
            {
                //si A est choisi 
                choisi = A;
                print("j'ai choisi maintenant =" + choisi);
                Vector3 millieu = Vector3.Lerp(mon_preferer.transform.position, choisi.transform.position, 0.5f);
                Instantiate(new_GO, millieu, Quaternion.identity); ;
                mon_preferer = new_GO;
            }
            if (choix == 1 && mon_preferer != B)
            {
                choisi = B;
                print("j'ai choisi maintenant =" + choisi);
                Vector3 millieu = Vector3.Lerp(mon_preferer.transform.position, choisi.transform.position, 0.5f);
                Instantiate(new_GO, millieu, Quaternion.identity); ;
                mon_preferer = new_GO;
            }
            if (choix == 2 && mon_preferer != C)
            {
                choisi = C;
                print("j'ai choisi maintenant =" + choisi);
                Vector3 millieu = Vector3.Lerp(mon_preferer.transform.position, choisi.transform.position, 0.5f);
                Instantiate(new_GO, millieu, Quaternion.identity); ;
                mon_preferer = new_GO;
            }
        }
    }
}