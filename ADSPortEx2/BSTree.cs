using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADSPortEx2
{
    //Binary Search Tree implementation for Assessed Exercise 2

    //Hints : 
    //Use lecture materials from Week 5
    // and lab sheet 'Lab 5: BinTree and BSTree' to aid with implementation.

    class BSTree<T> : BinTree<T> where T : IComparable
    {

        public BSTree()
        {
            root = null;
        }

        //Functions for EX.2A
        public void InsertItem(T item)
        {
            insertItem(item, ref root);
        }

        private void insertItem(T item, ref Node<T> tree)
        {
            if (root == null)
            {
                tree = new Node<T>(item);
            }
            else if (item.CompareTo(tree.Data)>0)
                insertItem(item, ref tree.Left);
            else if (item.CompareTo(tree.Data) > 0)
                insertItem(item, ref tree.Right);
        }
        public int Height()
        {
            return height(root);
        }
        private int max(int a, int b) // defining max
        {
            return (a > b) ? a : b;
        }

        private int height(Node<T> tree)
        {
            if (tree == null)
                return 0;
            else
                return 1 + max(height(tree.Left), height(tree.Right));
        }

        public T EarlieseGame()
        {
            if (root == null)
                return default(T);

            return earliest(root, root.Data);
        }

        private T earliest(Node<T> tree, T earliestSoFar)
        {
            if (tree == null)
                return earliestSoFar;

            VideoGame current = tree.Data as VideoGame;
            VideoGame earliestGame = earliestSoFar as VideoGame;

            if (current.Releaseyear < earliestGame.Releaseyear)
                earliestSoFar = tree.Data;

            earliestSoFar = earliest(tree.Left, earliestSoFar);
            earliestSoFar = earliest(tree.Right, earliestSoFar);

            return earliestSoFar;
        }




        //Functions for EX.2B

        public int Count()
        {
            throw new NotImplementedException();
        }

        public void Update(T item)
        {
            throw new NotImplementedException();
        }

        //Free space, use as necessary to address task requirements... 





    }// End of class
}
