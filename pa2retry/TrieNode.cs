using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace pa2retry
{
    public class TrieNode
    {
        public char letter { get; set; }
        public bool lastChar { get; set; }
        public Dictionary<char, TrieNode> edge { get; set; }

        public TrieNode(char c)
        {
            edge = new Dictionary<char, TrieNode>();
            this.letter = c;
        }

        public TrieNode getNext(TrieNode node)
        {
            TrieNode nextNode;
            if (node.edge.TryGetValue(node.letter, out nextNode))
                return nextNode;
            else
                return null;
        }

        public bool isNext(TrieNode node)
        {
            TrieNode nextNode;
            return 
        }
    }
}