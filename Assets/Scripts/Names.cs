using System;using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public static class Names
{
    private static ArrayList names = new ArrayList();


    static Names()
    {
        
        names.Add("Алла");
        names.Add("Геля");
        names.Add("Анна");
        names.Add("Тоня");
        names.Add("Валя");
        names.Add("Нина");
        names.Add("Оля");
        names.Add("Поля");
        names.Add("Софа");
        names.Add("Тася");
        names.Add("Таня");
        names.Add("Уля");
        names.Add("Юля");
        names.Add("Саша");
        names.Add("Леша");
        names.Add("Толя");
        names.Add("Вова");
        names.Add("Вася");
        names.Add("Витя");
        names.Add("Влад");
        names.Add("Гена");
        names.Add("Макс");
        names.Add("Марк");
        names.Add("Миша");
        names.Add("Коля");
        names.Add("Олег");
        names.Add("Паша");
        names.Add("Пётр");
        names.Add("Рома");
        names.Add("Стас");
        names.Add("Федя");
        names.Add("Юрий");
    }

    public static String GetRandomName()
    {
        return names[UnityEngine.Random.Range(0, names.Count)].ToString();
    }
} 

