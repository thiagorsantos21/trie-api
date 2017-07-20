using Trie.Console.Model;

namespace Trie.Services
{
    public static class TrieService
    {
       static TrieNode root = new TrieNode(' ');
        
        /// <summary>
        /// Insere uma nova palavra na Arvore
        /// </summary>
        /// <param name="word"></param>
        public static void insert(string word)
        {
            if (search(word) == true)
                return;

            TrieNode current = root;
            foreach (char ch in word.ToCharArray())
            {
                TrieNode child = current.subNode(ch);
                if (child != null)
                    current = child;
                else
                {
                    current.childList.Add(new TrieNode(ch));
                    current = current.subNode(ch);
                }
                current.count++;
            }
            current.isEnd = true;
        }

        /* Busca a palavra na Arvore*/
        public static bool search(string word)
        {
            TrieNode current = root;
            foreach (char ch in word.ToCharArray())
            {
                if (current.subNode(ch) == null)
                    return false;
                else
                    current = current.subNode(ch);
            }
            if (current.isEnd == true)
                return true;
            return false;
        }


        /* Retorna se a palavra existe na arvore */
        public static bool startsWith(string prefix)
        {
            var result = search(prefix);
            return result;
        }




    }
}