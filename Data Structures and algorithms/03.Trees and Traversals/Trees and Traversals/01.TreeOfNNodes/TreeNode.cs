namespace TreeOfNNodes
{
    using System;
    using System.Collections.Generic;

    public class TreeNode<T>
    {
        private T value;
        private List<TreeNode<T>> children;

        public TreeNode(T value)
        {
            this.Value = value;
            this.Children = new List<TreeNode<T>>();
        }

        public int ChildrenCount
        {
            get { return this.children.Count; }
        }

        public List<TreeNode<T>> Children
        {
            get
            {
                return new List<TreeNode<T>>(children);
            }
            private set
            {
                this.children = value;
            }
        }

        public bool HasParent { get; private set; }

        public T Value
        {
            get
            {
                return this.value;
            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Value cannot be null");
                }

                this.value = value;
            }
        }

        public void AddChild(TreeNode<T> child)
        {
            if (child == null)
            {
                throw new ArgumentNullException("Child cannot be null");
            }

            if (child.HasParent)
            {
                throw new ArgumentNullException("Child already has a parent");
            }

            child.HasParent = true;
            this.children.Add(child);
        }
    }
}