using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pair<T, U>
{
    public T m_first { get; set; }
    public U m_second { get; set; }

    public Pair()
    {

    }

    public Pair(T t_first, U t_second)
    {
        this.m_first = t_first;
        this.m_second = t_second;
    }
}

public class Upgrade
{
    private Pair<string, int> m_upgradePair = new Pair<string, int>("", 0);
    
    public Upgrade()
    {

    }

    public Upgrade(Pair<string, int> t_pair)
    {
        m_upgradePair = t_pair;
    }

    public void IncreaseLevel()
    {
        m_upgradePair.m_second += 1;
    }

    public void DecreaseLevel()
    {
        m_upgradePair.m_second -= 1;
    }

    public string GetUpgradeName()
    {
        return m_upgradePair.m_first;
    }

    public int GetUpgradeLevel()
    {
        return m_upgradePair.m_second;
    }
}
