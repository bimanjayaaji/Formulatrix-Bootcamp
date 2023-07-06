namespace Character_Interface;

public interface IBody : IHand, IFoot, IHead, ITorso
{
	void BodyWalking();
	void BodyRunning();
	void BodyKayang();
}
