import React from 'react';

const Footer: React.FC = () => {
    return (
        <footer>
            <p>&copy; {new Date().getFullYear()} Stock Exchange. All rights reserved.</p>
            <nav>
                <a href="/about">About Us</a>
                <a href="/contact">Contact</a>
                <a href="/privacy">Privacy Policy</a>
            </nav>
        </footer>
    );
};

export default Footer;