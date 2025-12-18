using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADSPortEx2
{
    //Binary Tree implementation for Assessed Exercise 2

    //Hints : 
    //Use lecture materials from Week 4B
    // and lab sheet 'Lab 5: BinTree and BSTree' to aid with implementation...

    class BinTree<T> where T : IComparable
    {
        private Node<T> root;
        public BinTree()
        {
            root = null;
        }

        public BinTree(Node<T> node)
        {
            root = node;
        }


        //Functions for EX.2A
        public void InOrder(ref string buffer)
        {
            inOrder(root, ref buffer);
        }

        private void inOrder(Node<T> tree, ref string buffer)
        { 
            if (tree!=null)
            {
                inOrder(tree.Left, ref buffer);
                buffer += tree.Data.ToString() + ",";
                inOrder(tree.Right, ref buffer);
            }

        }
        public void PreOrder(ref string buffer)
        {
            throw new NotImplementedException();
        }

        public void PostOrder(ref string buffer)
        {
            throw new NotImplementedException();
        }

        //Free space, use as necessary to address task requirements... 





    } // End of class
}
