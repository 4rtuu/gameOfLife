using System.Text;

namespace GameOfLife
{
    public static class Singleton
    {
        private static StringBuilder builder;
        public static StringBuilder Builder
        {
            get
            {
                if (builder == null)
                {
                    builder = new StringBuilder();
                }
                return builder;
            }
        }
    }
}
