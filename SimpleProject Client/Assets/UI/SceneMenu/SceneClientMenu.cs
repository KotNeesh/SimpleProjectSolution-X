using UnityEngine;
using SimpleTeam.Comm;
using SimpleTeam.Mess;
using SimpleTeam.GameOneID.Mess;
using SimpleTeam.Comm.Scenar;

namespace SimpleTeam.Sce
{
    public class SceneClientMenu : MonoBehaviour, ISceneMenuMessages
    {
        public GUIAccount Account;
        public GUISign Sign;
        public GUIChat Chat;
        public GUIProfile Profile;

        //ISceneScenario
        private SceneScenario _sceneScenario = new SceneScenario();

        public IScenario GetScenario()
        {
            return ((ISceneScenario)_sceneScenario).GetScenario();
        }



        private bool _isSignIn = false;

        public void SetStateSignIn(bool isSignIn)
        {
            _isSignIn = isSignIn;
            Account.SetStateSignIn(_isSignIn);
            Chat.SetStateSignIn(_isSignIn);
            Profile.SetStateSignIn(_isSignIn);
        }
        public void Start()
        {
            SetStateSignIn(false);
        }
        public void Update()
        {
        }


        //ISceneMenuMessages
        void ISceneMenuMessages.SetMessage(MessageChat message)
        {
            Chat.Set(message);
        }

        void ISceneMenuMessages.SetMessage(MessageAccount message)
        {
            Sign.Set(message);
        }

        void ISceneMenuMessages.SetMessage(MessageProfile message)
        {
            Profile.Set(message);
        }


    }
}
