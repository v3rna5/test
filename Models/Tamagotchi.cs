using System.Collections.Generic;
using System;

namespace TamaGotchi.Models
{
  public class TamaPet
  {
    private string _name;
    private int _feed;
    private int _sleep;
    private int _play;
    private int _id;
    private static List<TamaPet> _instances = new List<TamaPet> {};

    public TamaPet (string name)
    {
      _name = name;
      _feed = 5;
      _sleep = 5;
      _play = 5;
      _instances.Add(this);
      _id = _instances.Count;
    }

    public void SetFeed()
    {
      _feed += _feed;
    }
    public void SetRest()
    {
      _sleep += _sleep;
    }
    public void SetPlay()
    {
    _play += _play;
    }
    public void Timepass(){
      _feed = _feed -5;
      _sleep = _sleep -5;
      _play = _play -5;
    }
    public string GetName()
    {
      return _name;
    }
    public int GetFeed()
    {
      return _feed;
    }
    public int GetSleep()
    {
      return _sleep;
    }
    public int GetPlay()
    {
      return _play;
    }
    public int GetId()
    {
      return _id;
    }
    public static List<TamaPet> GetAll()
    {
        return _instances;
    }

    public static void ClearAll()
      {
        _instances.Clear();
      }


    public static TamaPet Find(int searchId)
    {
      return _instances[searchId-1];

}
  }
}
