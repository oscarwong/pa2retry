using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace pa2retry
{
    public class Trie
    {
        public TrieNode root;

        public Trie()
        {
            root = new TrieNode(' ');
        }

        public void insertWord(string word)
        {
            foreach (char c in word)
            {
                TrieNode node = new TrieNode(c);
            }
        }

        private void insertChar(char c)
        {

        }
    }
}