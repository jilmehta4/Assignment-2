using Microsoft.AspNetCore.Http;

namespace PIGGameApp.Models
{
    public class GameSession
    {
        private const string P1T = "_p1t";
        private const string P2T = "_p2t";
        private const string T = "_T";

        private ISession session;

        public GameSession(ISession session)
        {
            this.session = session;
        }

        public void SetT(int t)
        {
            session.SetInt32(T, t);
        }

        public int GetT() => session.GetInt32(T) ?? 0;

        public void SetP1T(int t)
        {
            session.SetInt32(P1T, t);
        }

        public int GetP1T() => session.GetInt32(P1T) ?? 0;

        public void SetP2T(int t)
        {
            session.SetInt32(P2T, t);
        }

        public int GetP2T() => session.GetInt32(P2T) ?? 0;
    }
}