import React from 'react';
import Header from '../components/Header';
import Footer from '../components/Footer';

const Home: React.FC = () => {
    return (
        <div>
            <Header />
            <h1>Welcome to the Stock Exchange</h1>
            <p>Explore the latest stocks and market trends.</p>
            <Footer />
        </div>
    );
};

export default Home;