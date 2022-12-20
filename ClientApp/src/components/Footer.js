import './Footer.css';

const Footer = () => {
    const year = new Date().getFullYear();

    return <footer>{'Coopyright © Upbeat Code ' + year}</footer>
};

export default Footer;