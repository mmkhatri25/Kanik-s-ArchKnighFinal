using Dxx.Util;
using UnityEngine;

public class AIMove1002 : AIMoveBase
{
	protected float Move_NextTime;

	protected float Move_NextDurationTime;

	protected float Move_NextX;

	protected float Move_NextY;

	private float Move_NextDurationTimeMin;

	private float Move_NextDurationTimeMax;

	private int min;

	private int max;

	public AIMove1002(EntityBase entity, int min, int max = -1)
		: base(entity)
	{
		this.min = min;
		this.max = ((max != -1) ? max : min);
	}

	protected override void OnInitBase()
	{
		Move_NextDurationTimeMin = (float)min / 1000f;
		Move_NextDurationTimeMax = (float)max / 1000f;
		RandomNextMove();
	}

	protected override void OnUpdate()
	{
		if (!m_Entity.m_AttackCtrl.GetAttacking())
		{
			MoveNormal();
		}
	}

	private void MoveNormal()
	{
		if (Updater.AliveTime < Move_NextTime + Move_NextDurationTime)
		{
			if (!m_Entity.m_MoveCtrl.GetMoving())
			{
				AIMoveStart();
			}
			else
			{
				AIMoving();
			}
		}
		else
		{
			AIMoveEnd();
		}
	}

	private void AIMoveStart()
	{
		m_MoveData.angle = Utils.getAngle(Move_NextX, Move_NextY);
		m_MoveData.direction = new Vector3(Move_NextX, 0f, Move_NextY);
		m_Entity.m_AttackCtrl.RotateHero(m_MoveData.angle);
		m_Entity.m_MoveCtrl.AIMoveStart(m_MoveData);
	}

	private void AIMoving()
	{
		m_Entity.m_MoveCtrl.AIMoving(m_MoveData);
	}

	private void AIMoveEnd()
	{
		End();
	}

	protected virtual void RandomNextMove()
	{
		int num = 0;
		RandomNextMoveOnce();
		while (!IsRandomValid() && num < 100)
		{
			RandomNextMoveOnce();
			num++;
		}
	}

	private void RandomNextMoveOnce()
	{
		Move_NextTime = Updater.AliveTime;
		Move_NextDurationTime = GameLogic.Random(Move_NextDurationTimeMin, Move_NextDurationTimeMax);
		Vector2 normalized = new Vector2(GameLogic.Random(-1f, 1f), GameLogic.Random(-1f, 1f)).normalized;
		Move_NextX = normalized.x;
		Move_NextY = normalized.y;
	}

	protected bool IsRandomValid()
	{
		return true;
	}

	protected override void OnEnd()
	{
		m_Entity.m_MoveCtrl.AIMoveEnd(m_MoveData);
	}
}
