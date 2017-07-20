using System.Collections.Generic;

namespace Trie.Console.Model
{
    public class TrieNode
    {
        public char character { get; set; }
        public bool isEnd { get; set; }
        public int count { get; set; }
        public List<TrieNode> childList { get; set; }


        public TrieNode(char c)
        {
            character = c;
            count = 0;
            isEnd = false;
            childList = new List<TrieNode>();
        }

        public TrieNode subNode(char c)
        {
            if (childList != null)
            {
                foreach (var item in childList)
                {
                    if (item.character == c)
                        return item;
                }
                return null;
            }
            else
                return null;

        }

    }
}