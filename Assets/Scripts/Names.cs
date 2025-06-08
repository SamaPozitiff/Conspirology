using System;using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public static class Names
{
    private static ArrayList names = new ArrayList();


    static Names()
    {
        names.Add("Александра");
        names.Add("Алёна");
        names.Add("Алина");
        names.Add("Алиса");
        names.Add("Алла");
        names.Add("Анастасия");
        names.Add("Ангелина");
        names.Add("Анна");
        names.Add("Антонина");
        names.Add("Арина");
        names.Add("Валентина");
        names.Add("Наталья");
        names.Add("Нина");
        names.Add("Ольга");
        names.Add("Полина");
        names.Add("Раиса");
        names.Add("Светлана");
        names.Add("София");
        names.Add("Таисия");
        names.Add("Тамара");
        names.Add("Татьяна");
        names.Add("Ульяна");
        names.Add("Юлия");
        names.Add("Александр");
        names.Add("Алексей");
        names.Add("Анатолий");
        names.Add("Андрей");
        names.Add("Антон");
        names.Add("Аркадий");
        names.Add("Арсений");
        names.Add("Артём");
        names.Add("Богдан");
        names.Add("Борис");
        names.Add("Вадим");
        names.Add("Валентин");
        names.Add("Валерий");
        names.Add("Василий");
        names.Add("Виктор");
        names.Add("Виталий");
        names.Add("Владимир");
        names.Add("Владислав");
        names.Add("Вячеслав");
        names.Add("Геннадий");
        names.Add("Макар");
        names.Add("Максим");
        names.Add("Марк");
        names.Add("Матвей");
        names.Add("Михаил");
        names.Add("Никита");
        names.Add("Николай");
        names.Add("Олег");
        names.Add("Павел");
        names.Add("Пётр");
        names.Add("Роман");
        names.Add("Руслан");
        names.Add("Святослав");
        names.Add("Семён");
        names.Add("Сергей");
        names.Add("Станислав");
        names.Add("Степан");
        names.Add("Тимофей");
        names.Add("Фёдор");
        names.Add("Юрий");
        names.Add("Ярослав");
    }

    public static String GetRandomName()
    {
        return names[UnityEngine.Random.Range(0, names.Count)].ToString();
    }
} 

