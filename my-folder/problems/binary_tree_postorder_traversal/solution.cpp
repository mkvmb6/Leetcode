/**
 * Definition for a binary tree node.
 * struct TreeNode {
 *     int val;
 *     TreeNode *left;
 *     TreeNode *right;
 *     TreeNode() : val(0), left(nullptr), right(nullptr) {}
 *     TreeNode(int x) : val(x), left(nullptr), right(nullptr) {}
 *     TreeNode(int x, TreeNode *left, TreeNode *right) : val(x), left(left), right(right) {}
 * };
 */
class Solution {
public:
    std::vector<int> postorderTraversal(TreeNode* root) {
        stack<TreeNode*> mStack;
        vector<int> ans;
        
        if (root)
            mStack.push(root);
        
        while (mStack.size()) {
            auto tp = mStack.top();
            ans.push_back(tp->val);
            mStack.pop();
            
            if (tp->left)
                mStack.push(tp->left);
            if (tp->right)
                mStack.push(tp->right);
        }
        
        reverse(ans.begin(), ans.end());
        return ans;
    }
};