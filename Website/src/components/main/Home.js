import "../../styles/main/Home.css";
import Hero from "./partials/Hero.js";

function Home() {
    return (
        <div className="homemap">
            <Hero context="welcome" />

            {/* TODO - Fix little screen hero border-tripping */}
            <svg
                fill="current"
                preserveAspectRatio="none"
                viewBox="0 0 1680 40"
                className="round"
            >
                <path
                    d="M0 40h1680V30S1340 0 840 0 0 30 0 30z"
                    fill="currentColor"
                ></path>
            </svg>

            <div className="content">
                <div>
                    <h1>
                        <b>#</b> Les réponses à vos questions
                    </h1>

                    <p>
                        Vous souhaitez tout de suite parcourir les whys posé par
                        des partners ou répondre aux leurs ? Ne perdez pas plus
                        de temps !
                    </p>

                    <a className="button" href="./T">
                        <span>Explorez les topics</span>
                    </a>
                </div>

                {/*  TODO - Gallery to component */}
                <div id="systit">
                    <h1>
                        <b>#</b>Notre système
                    </h1>

                    <ul className="container">
                        <li className="contained">
                            Non-résolu
                            <div className="box" id="topic">
                                <svg
                                    style={{ width: "3rem", height: "3rem" }}
                                    viewBox="0 0 24 24"
                                >
                                    <path
                                        fill="currentColor"
                                        d="M17,12V3A1,1 0 0,0 16,2H3A1,1 0 0,0 2,3V17L6,13H16A1,1 0 0,0 17,12M21,6H19V15H6V17A1,1 0 0,0 7,18H18L22,22V7A1,1 0 0,0 21,6Z"
                                    />
                                </svg>
                                <h2>T(topic): les sujets</h2>
                                Un peu d'organisation est nécessaire.
                            </div>
                        </li>

                        <li className="contained">
                            En cours
                            <div className="box" id="why">
                                <svg
                                    style={{ width: "3rem", height: "3rem" }}
                                    viewBox="0 0 24 24"
                                >
                                    <path
                                        fill="currentColor"
                                        d="M15.07,11.25L14.17,12.17C13.45,12.89 13,13.5 13,15H11V14.5C11,13.39 11.45,12.39 12.17,11.67L13.41,10.41C13.78,10.05 14,9.55 14,9C14,7.89 13.1,7 12,7A2,2 0 0,0 10,9H8A4,4 0 0,1 12,5A4,4 0 0,1 16,9C16,9.88 15.64,10.67 15.07,11.25M13,19H11V17H13M12,2A10,10 0 0,0 2,12A10,10 0 0,0 12,22A10,10 0 0,0 22,12C22,6.47 17.5,2 12,2Z"
                                    />
                                </svg>
                                <h2>Y(why): les questions</h2>
                                Les questions que vous et ceux qui passeront
                                après vous se posent.
                            </div>
                        </li>

                        <li className="contained">
                            résolu
                            <div className="box" id="partner">
                                <svg
                                    style={{ width: "3rem", height: "3rem" }}
                                    viewBox="0 0 24 24"
                                >
                                    <path
                                        fill="currentColor"
                                        d="M16 17V19H2V17S2 13 9 13 16 17 16 17M12.5 7.5A3.5 3.5 0 1 0 9 11A3.5 3.5 0 0 0 12.5 7.5M15.94 13A5.32 5.32 0 0 1 18 17V19H22V17S22 13.37 15.94 13M15 4A3.39 3.39 0 0 0 13.07 4.59A5 5 0 0 1 13.07 10.41A3.39 3.39 0 0 0 15 11A3.5 3.5 0 0 0 15 4Z"
                                    />
                                </svg>
                                <h2>P(partner): les utilisateurs</h2>
                                Ceux qui posent les questions, mais surtout ceux
                                qui y répondent.
                            </div>
                        </li>
                    </ul>
                </div>

                <div>
                    <h1>
                        <b>#</b> Nos origines
                    </h1>

                    <div>
                        <div className="left vl-red">
                            <h2>Né du WEB</h2>
                            <b>TYP signifie "Thank You Partner".</b>Cet acronyme
                            est utilisé pour représenter la phrase "merci,
                            partenaire". Il est très utilisé sur Internet dans
                            les jeux coopératifs pour remercier votre partenaire
                            pour quelque chose qu'il/elle a fait pour vous ou
                            simplement pour le/la remercier en général d'être un
                            bon partenaire.
                        </div>
                    </div>

                    <div className="right vl-org">
                        <h2>Pour la communauté</h2>
                        <b>
                            En 2020 les "typeError" sont les erreurs les plus
                            répandues.
                        </b>
                        (vu quelque part sur le net)
                    </div>

                    <div className="left vl-grn">
                        <h2>Des développeurs</h2>
                        <b>Le type en typescript s'écrit name:string.</b> Ouais,
                        à ce point-là, on avait déjà trouvé le nom, on a juste
                        cherché toutes les coïncidences.
                    </div>
                </div>
            </div>

            <svg
                fill="none"
                preserveAspectRatio="none"
                viewBox="0 0 1680 40"
                className="round bottom"
            >
                <path
                    d="M0 40h1680V30S1340 0 840 0 0 30 0 30z"
                    fill="currentColor"
                ></path>
            </svg>
            <div className="content bottom">
                <div>
                    <h1>
                        <b>#</b> Notre outil de modération
                    </h1>
                    <p>
                        Si vous faites parti de notre chaleureuse equipe de
                        modération vous pouvez telecharger l'applications de
                        modération juste ici
                    </p>
                    <a className="button" href="Null">
                        Télécharger
                    </a>
                </div>
            </div>
        </div>
    );
}

export default Home;
