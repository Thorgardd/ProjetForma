import "../../../styles/main/partials/Hero.css";
function Hero(props) {
    return (
        <div className="hero">
            <img
                className="one"
                src={"/assets/img/hero-" + props.context + "/one.png"}
                alt="logo de TYP:Error"
            />

            <img
                className="two"
                src={"/assets/img/hero-" + props.context + "/two.png"}
                alt="logo de TYP:Error"
            />

            <img
                className=" three"
                src={"/assets/img/hero-" + props.context + "/three.png"}
                alt="logo de TYP:Error"
            />

            <img
                className="wave"
                src={"/assets/img/hero-" + props.context + "/TYP_hero.png"}
                alt="logo de TYP:Error"
            />

            <img
                className="four"
                src={"/assets/img/hero-" + props.context + "/four.png"}
                alt="logo de TYP:Error"
            />

            <img
                className="five"
                src={"/assets/img/hero-" + props.context + "/five.png"}
                alt="logo de TYP:Error"
            />

            <img
                className="six"
                src={"/assets/img/hero-" + props.context + "/six.png"}
                alt="logo de TYP:Error"
            />
        </div>
    );
}

export default Hero;
