using UnityEngine;
using UnityEngine.Events;

public class EventOnReach : MonoBehaviour
{
    [SerializeField] private int m_goal = 2;
    [SerializeField] private bool m_repeat = false;
    [SerializeField] private UnityEvent m_onReach;

    private int m_amount = 0;
    private bool m_goalReached = false;

    public void Add(int _amount)
    {
        m_amount += _amount;

        if (!m_repeat && m_goalReached) return;
        if (m_amount >= m_goal)
        {
            m_onReach.Invoke();
            m_goalReached = true;
        }
    }
}
