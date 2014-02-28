using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;

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
            int wordLength = word.Length;
            int currentIndex = 0;
            TrieNode currentNode = root;
            foreach (char c in word)
            {
                if (!currentNode.edge.ContainsKey(c))
                {
                    TrieNode newNode = new TrieNode(c);
                    currentNode.edge.Add(c, newNode);
                    currentNode = newNode;
                    currentIndex++;
                    if (currentIndex == wordLength)
                        currentNode.lastChar = true;
                    else
                        continue;
                } else 
                {
                    currentIndex++;
                    currentNode = currentNode.getNode(c);
                    if (currentIndex == wordLength)
                        currentNode.lastChar = true;
                }
            }
        }

        public List<string> searchPrefix(string prefix)
        {
            TrieNode currentNode = root;
            List<string> words = new List<string>();
            currentNode = findRoot(prefix);
            foreach(var pair in currentNode.edge)
            {
                StringBuilder sb = new StringBuilder();
                sb.Append(prefix);
                while (currentNode.edge != null)
                {

                }
            }
        }

        private List<string> getWords(TrieNode currentNode, StringBuilder sb, string prefix)
        {
            List<string> words = new List<string>();
            foreach (var pair in currentNode.edge)
            {
                if (!pair.Value.lastChar)
                {
                    sb.Append(pair.Key);
                    getWords(pair.Value, sb, prefix);
                }
                else
                {
                    words.Add(sb.ToString());
                    if (words.Count >= 10)
                        break;
                    sb = new StringBuilder();
                    sb.Append(prefix);
                }
            }
            return words;
        }

        private TrieNode findRoot(string prefix)
        {
            TrieNode currentNode = root;
            foreach (char c in prefix)
            {
                if(currentNode.edge.ContainsKey(c))
                    currentNode = currentNode.getNode(c);
                else
                    return null;
            }
            return currentNode;
        }
    }
}