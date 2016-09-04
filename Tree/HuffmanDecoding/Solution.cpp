struct node
{
    int freq;
    char data;
    node * left;
    node * right;

}node;


void decode_huff(node * root,string s)
{
    int len = s.size();
    string ret = "";

    node * tempNode = root;

    for(int i = 0; i <len; i++)
    {
        char cur = s[i];

        if(cur=='0')
        {
            tempNode = tempNode->left;
        }
        else
        {
            tempNode = tempNode->right;
        }

        while(tempNode->left == NULL && tempNode->right == NULL)
        {
            cout << tempNode->data;
            tempNode = root;
            
            break;
        }
    }
}

//java version : 
// void decode(String S, Node root)
// {
//     StringBuilder sb = new StringBuilder();
//     Node c = root;
//     for (int i = 0; i < S.length(); i++) {
//         c = S.charAt(i) == '1' ? c.right : c.left;
//         if (c.left == null && c.right == null) {
//             sb.append(c.data);
//             c = root;
//         }
//     }
//     System.out.print(sb);
// }