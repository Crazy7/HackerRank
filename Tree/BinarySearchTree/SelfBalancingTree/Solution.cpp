//Url : https://www.hackerrank.com/challenges/self-balancing-tree

typedef struct node
{
    int val;
    struct node *left;
    struct node *right;
    int ht;
}node;

node *create_node(int val)
{
    node *pNew = new node;
    pNew->val = val;
    pNew->ht  = 0;
    pNew->left = pNew->right = nullptr;
    
    return pNew;
}

int height(node *p)
{
    if(!p) return -1;
    return p->ht;
}

int calcHeight(node *p)
{
    if (!p) return 0;
    return 1 + max(height(p->left), height(p->right));
}

node *right_rotate(node *p)
{
    node *pOrigRoot = p;
    node *root = p->left;
    pOrigRoot->left = root->right;
    root->right = pOrigRoot;
    
    pOrigRoot->ht = calcHeight(pOrigRoot);
    root->ht = calcHeight(root);
    
    return root;
}

node *left_rotate(node *p)
{
    node *pOrigRoot = p;
    node *root = p->right;
    pOrigRoot->right = root->left;
    root->left = pOrigRoot;
    
    pOrigRoot->ht = calcHeight(pOrigRoot);
    root->ht = calcHeight(root);
    
    return root;
}

int balance_factor(node *p)
{
    if (!p) return 0;
    return height(p->left) - height(p->right);
}

node *balance(node *p)
{
    int w = balance_factor(p);

    if (!p || abs(w) < 2)
        return p;
    
    if (w > 0)
    {
        if(balance_factor(p->left) < 0)
        {
            p->left = left_rotate(p->left);
        }
        return right_rotate(p);
    }
    else
    {
        if(balance_factor(p->right) > 0)
        {
            p->right = right_rotate(p->right);
        }
        return left_rotate(p);
    }
    
    return p;
}

node * insert(node * root,int val)
{
    if (val < root->val)
    {
        if(!root->left)
        {
            root->left = create_node(val);
        }
        else
        {
            root->left = insert(root->left, val);
        }
    }
    else
    {
        if(!root->right)
        {
            root->right = create_node(val);
        }
        else
        {
            root->right = insert(root->right, val);
        }
    }

    root->ht = calcHeight(root);
    
    return balance(root);
}