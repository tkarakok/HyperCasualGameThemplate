using System;
using DG.Tweening;
public class EventManager : Singleton<EventManager>
{
    public Action MainMenu;
    public Action InGame;
    public Action EndGame;
    public Action GameOver;

    private void Start()
    {
        // Subscribe all event
        MainMenu += SubscribeFunction;
        MainMenu();
    }


    void SubscribeFunction()
    {
       
    }
}