using UnityEngine;

public class AI5003 : AIBase
{
	private int callid = 3021;

	protected override void OnInitOnce()
	{
		InitCallData(callid, 2, int.MaxValue, 1, 2, 3);
	}

	protected override void OnInit()
	{
		ActionChooseRandom actionChooseRandom = new ActionChooseRandom();
		actionChooseRandom.ConditionBase = base.GetIsAlive;
		actionChooseRandom.AddAction(7, GetMove());
		actionChooseRandom.AddAction(10, GetAttack());
		actionChooseRandom.AddAction(10, GetCall());
		AddAction(actionChooseRandom);
	}

	protected override void OnAIDeInit()
	{
	}

	private ActionBase GetMove()
	{
		ActionSequence actionSequence = new ActionSequence();
		actionSequence.ConditionBase = base.GetIsAlive;
		actionSequence.AddAction(new AIMove1008(m_Entity, 1f, 1000));
		actionSequence.AddAction(GetActionWait("actionwait", 300));
		ActionSequence actionSequence2 = new ActionSequence();
		actionSequence2.ConditionBase = base.GetIsAlive;
		actionSequence2.AddAction(new AIMove1008(m_Entity, 1f, 1000));
		actionSequence2.AddAction(GetActionWait("actionwait", 300));
		ActionChoose actionChoose = new ActionChoose();
		actionChoose.m_Entity = m_Entity;
		actionChoose.Condition = RandomMove3;
		actionChoose.ResultTrue = actionSequence2;
		actionSequence.AddAction(actionChoose);
		return actionSequence;
	}

	private bool RandomMove3()
	{
		return Random.Range(0, 100) < 50;
	}

	private ActionBase GetAttack()
	{
		ActionSequence actionSequence = new ActionSequence();
		actionSequence.ConditionBase = base.GetIsAlive;
		actionSequence.AddAction(GetActionAttack("actionattack", 5009));
		actionSequence.AddAction(GetActionWait("actionwait", 1000));
		return actionSequence;
	}

	private ActionBase GetCall()
	{
		ActionSequence actionSequence = new ActionSequence();
		actionSequence.ConditionBase1Data = 3021;
		actionSequence.ConditionBase1 = base.GetCanCall;
		actionSequence.AddAction(GetActionCall(3021));
		actionSequence.AddAction(GetActionWait("actionwait", 1700));
		return actionSequence;
	}
}
