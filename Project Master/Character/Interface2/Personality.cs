namespace Character_Interface;

public interface IPersonality : IEmotion, ICognitive
{
	void BeingHuman();
	void ChangeName();	
}
