import React from 'react';

const categories = ['Technology', 'Finance', 'Healthcare', 'Consumer Goods', 'Energy'];

const CategoryMenu: React.FC<{ onSelectCategory: (category: string) => void }> = ({ onSelectCategory }) => {
    return (
        <div className="category-menu">
            <h2>Filter by Category</h2>
            <ul>
                {categories.map((category) => (
                    <li key={category} onClick={() => onSelectCategory(category)}>
                        {category}
                    </li>
                ))}
            </ul>
        </div>
    );
};

export default CategoryMenu;