import React from 'react';

const Header: React.FC = () => {
    return (
        <header>
            <h1>Stock Exchange</h1>
            <nav>
                <ul>
                    <li><a href="/">Home</a></li>
                    <li><a href="/stocks">Stocks</a></li>
                    <li><a href="/categories">Categories</a></li>
                </ul>
            </nav>
        </header>
    );
};

export default Header;